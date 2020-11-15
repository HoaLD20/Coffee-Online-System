using Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Product : Form
    {

        productsList pro;
        string imgUrl = null;
        products product;
        SqlCommand cmd;
        SqlConnection conn;
        int indexCategory;//lay ID của category
        DBConectionManager db;
        SqlDataAdapter da;
        string checkgender = null;
        EmployeeList empList;
        CustomerList cusList;
        string checkUpdateOrAdd = "";//kiem tra khi click vao table employee thi data se hien lien textbox username, luc nay thi label check loi username trung se khong hien thi, loi chi hien thi khi add new
        bool excuteEmail = false;//neu khong co loi gi gi ht thi moi thuc hien crud;
        bool excutePhone = false;
        bool excuteUsername = false;
        public Product()
        {

            InitializeComponent();
            pro = new productsList();
            db = new DBConectionManager();
            empList = new EmployeeList();
            cusList = new CustomerList();
        }

        /**
         * la thong tin cua san pham
         * */
        public void showProduct()
        {
            DataTable dt = pro.getProduct();
            tbProduct.DataSource = dt;
        }
        /**
        * la thong tin cua employeee
        * */
        public void showEmployee()
        {
            DataTable dt = empList.getEmployee();
            tbEmployee.DataSource = dt;
        }
        /**
        * la thong tin cua customer
        * */
        public void showCustomer()
        {
            DataTable dt = cusList.getCustomer();
            tbCustomer.DataSource = dt;
        }

        //lay caegory vao combobox
        private void Product_Load(object sender, EventArgs e)
        {
            checkUpdateOrAdd = "add";
            numericPrice.Text = "";
            numericAvalable.Text = "";
            txtUsername.Enabled = true;
            txtIDCus.Enabled = false; ;
            txtIDEmp.Enabled = false;
            txtIDPro.Enabled = false;
            conn = db.GetConnection();
            string sql = "select * from Category";
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbbCategory.Items.Add(dr["namecategory"]).ToString();
                cbbSearchCategory.Items.Add(dr["nameCategory"]).ToString();//load data vao cbbsearch

            }
            conn.Close();

            showProduct();//lay toan bo thong tin cua san pham len(status=1) 
            showEmployee();//lay toan bo thong tin cua Employee len(status =1) 
            showCustomer();
        }
        public void refresh()
        {
            txtIDPro.Text = "";
            txtDescripton.Text = "";
            txtNamePro.Text = "";
            numericPrice.Text = "";
            cbbCategory.Text = "";
            txtURL.Text = "";
            numericAvalable.Text = "";
            pictureBox.Image = null;
            lblEmail.Text = "";
            lblCheckPhone.Text = "";
            cbbCategory.SelectedIndex = -1;
            txtSearchName.Text = "";
            cbbSearchCategory.SelectedIndex = -1;
            //refresh employee
            txtIDEmp.Text = "";
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtUsername.Text = "";
            txtPass.Text = "";
            cbbPosition.SelectedIndex = -1;
            radioFemale.Checked = false;
            radioMale.Checked = false;
            lblPass.Visible = true;
            txtPass.Visible = true;
            txtUsername.Enabled = true;
            lblEmail.Visible = false;//an thong bao loi email
            lblCheckPhone.Visible = false;//an thong bao loi phone
            panelPassword.Visible = true;
            txtsSearchFullname.Text = "";
            //refresh customer
            txtIDCus.Text = "";
            txtFullNameCus.Text = "";
            txtEmailCus.Text = "";
            txtPhoneCus.Text = "";
            txtUsernameCus.Text = "";           
            txtUsernameCus.Enabled = true;
            radioFemailCus.Checked = false;
            radioMaleCus.Checked = false;
            txtSearchFullnameCus.Text = "";
        }

        /**
         * PRODUCT MANAGEMENT ============================================================================
         * 
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexCategory = cbbCategory.SelectedIndex + 1;//lay chi so cua category khi chon vào combobox
        }

        private void tbProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIDPro.Enabled = false;
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtIDPro.Text = tbProduct.Rows[index].Cells["IDProduct1"].Value.ToString().Trim();
                txtIDPro.Enabled = false;
                txtNamePro.Text = tbProduct.Rows[index].Cells["nameProduct1"].Value.ToString().Trim();
                numericAvalable.Text = tbProduct.Rows[index].Cells["available1"].Value.ToString().Trim();
                numericPrice.Text = tbProduct.Rows[index].Cells["price1"].Value.ToString().Trim();
                txtDescripton.Text = tbProduct.Rows[index].Cells["description1"].Value.ToString().Trim();
                cbbCategory.SelectedIndex = int.Parse(tbProduct.Rows[index].Cells["IDCategory1"].Value.ToString().Trim()) - 1;//-1 de lay dc dung vi tri trong combobox
                txtURL.Text = tbProduct.Rows[index].Cells["imageUrl1"].Value.ToString().Trim();
                Byte[] imgData = new Byte[0];
                imgData = (Byte[])tbProduct.Rows[index].Cells["photo1"].Value;
                MemoryStream ms = new MemoryStream(imgData);
                pictureBox.Image = Image.FromStream(ms);


            }
        }

        private void btnImage_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imgUrl = ofd.FileName;
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                    txtURL.Text = imgUrl;
                }
            }
        }


        private void bntAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamePro.Text) || string.IsNullOrEmpty(numericAvalable.Text) || string.IsNullOrEmpty(cbbCategory.Text) || string.IsNullOrEmpty(txtURL.Text) || string.IsNullOrEmpty(numericPrice.Text) || string.IsNullOrEmpty(txtDescripton.Text))
            {
                MessageBox.Show("Please enter the complete information of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Image img = pictureBox.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                conn = db.GetConnection();
                conn.Open();
                string sql = "insert into Product(IDCategory,nameProduct, available, price,description,imageUrl, photo, status) values (@IDCategory,@nameProduct,@available,@price,@description,@imageUrl,@photo,1)";
                //tao ket noi toi sql

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@nameProduct", txtNamePro.Text); //parameter này sẽ được thay thế bởi giá trị thực sự của parameter khi SqlCommand thực thi
                cmd.Parameters.Add("@available", numericAvalable.Text);
                cmd.Parameters.Add("@imageUrl", txtURL.Text);
                cmd.Parameters.Add("@price", double.Parse(numericPrice.Text));


                cmd.Parameters.Add("@description", txtDescripton.Text);
                cmd.Parameters.Add("@IDCategory", indexCategory);
                cmd.Parameters.Add("@photo", arr);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product saved");
                conn.Close();
                showProduct();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            conn = db.GetConnection();
            conn.Open();
            string sql = "update Product set nameProduct = @nameProduct, available = @available, imageUrl = @imageUrl, price = @price, description = @description, IDCategory = @IDCategory, photo = @photo where IDProduct = @IDProduct";
            cmd = new SqlCommand(sql, conn);
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();
            cmd.Parameters.Add("@nameProduct", txtNamePro.Text);
            cmd.Parameters.Add("@available", numericAvalable.Text);
            cmd.Parameters.Add("@imageUrl", txtURL.Text);
            cmd.Parameters.Add("@price", double.Parse(numericPrice.Text));
            cmd.Parameters.Add("@description", txtDescripton.Text);
            cmd.Parameters.Add("@IDCategory", cbbCategory.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@photo", pic);
            cmd.Parameters.Add("@IDProduct", txtIDPro.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Detail Updated...");

            SqlCommand loadAgain = new SqlCommand("select * from Product where status = 1", conn);
            DataTable dt = new DataTable();
            dt.Load(loadAgain.ExecuteReader());
            tbProduct.DataSource = dt;
            conn.Close();
            refresh();
        }

        private void bntDelete_Click_1(object sender, EventArgs e)
        {
            conn = db.GetConnection();
            conn.Open();
            string sql = "update Product set status = 0 where IDProduct = @IDProduct";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@IDProduct", txtIDPro.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete success!");
            conn.Close();
            showProduct();
            refresh();
        }

        /**
         * search by name product
         * */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbProduct.DataSource = pro.searchByNameProduct(txtSearchName.Text);
        }

        /**
         * search by category
         * */
        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            tbProduct.DataSource = pro.searchByCategory(cbbSearchCategory.SelectedIndex+1);//lay index cua cbb +1 thi moi ra dc idcategory dung (vi cbb co chi so dau tien la 0)
        }

        /**
         * show lai toan bo thong tin sau khi search xong
         * */
        private void btnReload_Click(object sender, EventArgs e)
        {
            showProduct();
        }

        /*
         * 
         * EMPLOYEE MANAGEMENT ==================================================================================================
         * 
         * */


        private void tbEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPassword.Visible = false;
            checkUpdateOrAdd = "update";
            lblCheckUsername.Text = "";
            txtUsername.Enabled = false;
            lblPass.Visible = false;
            txtPass.Visible = false;
            txtIDEmp.Enabled = false;
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtIDEmp.Text = tbEmployee.Rows[index].Cells["IDEmployee"].Value.ToString().Trim();
                txtIDEmp.Enabled = false;
                txtFullname.Text = tbEmployee.Rows[index].Cells["fullNameEmp"].Value.ToString().Trim();
                txtPhone.Text = tbEmployee.Rows[index].Cells["phoneEmp"].Value.ToString().Trim();
                txtEmail.Text = tbEmployee.Rows[index].Cells["emailEmp"].Value.ToString().Trim();
                dateDOB.Value = Convert.ToDateTime(tbEmployee.Rows[index].Cells["DOBEmp"].Value.ToString());
                if (tbEmployee.Rows[index].Cells["genderEmp"].Value.ToString().Equals("Female"))
                {
                    radioFemale.Select();
                }
                else
                {
                    radioMale.Select();
                }
                txtUsername.Text = tbEmployee.Rows[index].Cells["usernameEmp"].Value.ToString().Trim();

                cbbPosition.SelectedItem = tbEmployee.Rows[index].Cells["position"].Value.ToString().Trim();//-1 de lay dc dung vi tri trong combobox



            }
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            checkgender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkgender = "Female";
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cbbPosition.Text))
            {
                MessageBox.Show("Please enter the complete information of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (excuteUsername && excutePhone && excuteEmail)//neu k co loi nhap sai nao cua ng dung thi thuc hien add new
                {
                    lblEmail.Visible = false;//an thong bao loi email
                    lblCheckPhone.Visible = false;//an thong bao loi phone
                    lblCheckPhone.Text = "";
                    lblEmail.Text = "";
                    lblCheckUsername.Text = "";
                    conn = db.GetConnection();
                    conn.Open();
                    string sql = "insert into Employee( fullnameEmp, phoneEmp,emailEmp,DOBEmp, genderEmp, usernameEmp,position, statusEmp) values (@fullnameEmp,@phoneEmp,@emailEmp,@DOBEmp,@genderEmp,@usernameEmp,@position,1)";
                    //tao ket noi toi sql

                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@fullnameEmp", txtFullname.Text); //parameter này sẽ được thay thế bởi giá trị thực sự của parameter khi SqlCommand thực thi
                    cmd.Parameters.Add("@phoneEmp", txtPhone.Text);
                    cmd.Parameters.Add("@emailEmp", txtEmail.Text);
                    cmd.Parameters.Add("@DOBEmp", dateDOB.Value);
                    cmd.Parameters.Add("@genderEmp", checkgender);
                    cmd.Parameters.Add("@usernameEmp", txtUsername.Text);
                    cmd.Parameters.Add("@position", cbbPosition.SelectedItem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee saved");
                    //role 1 la employee, role 0 la khach hang
                    string sqlAccount = "insert into Account (username, password, role) values (@username,@password,1)";
                    cmd = new SqlCommand(sqlAccount, conn);
                    cmd.Parameters.Add("@username", txtUsername.Text);
                    cmd.Parameters.Add("@password", empList.MD5Hash(txtPass.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    refresh();
                    showEmployee();
                }
                else
                {
                    MessageBox.Show("You need to enter all fields correctly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            checkUpdateOrAdd = "add";//lam cho thong bao loi trung username xuat hien khi nhap trung, phan biet voi truong hop khi clip 1 hang tu table thi se khong hien thong bao khi trung username
            refresh();

        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPhone.Text)||string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cbbPosition.Text))
            {
                MessageBox.Show("Please enter the complete information of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (excutePhone && excuteEmail)//neu k co loi nhap sai nao cua ng dung thi thuc hien update
                {
                    conn = db.GetConnection();
                    conn.Open();
                    string sql = "update Employee set fullnameEmp = @fullnameEmp, phoneEmp = @phoneEmp, emailEmp = @emailEmp, DOBEmp = @DOBEmp, genderEmp = @genderEmp,  position = @position,statusEmp = 1 where IDEmployee = @IDEmployee";
                    cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.Add("@fullnameEmp", txtFullname.Text); //parameter này sẽ được thay thế bởi giá trị thực sự của parameter khi SqlCommand thực thi
                    cmd.Parameters.Add("@phoneEmp", txtPhone.Text);
                    cmd.Parameters.Add("@emailEmp", txtEmail.Text);
                    cmd.Parameters.Add("@DOBEmp", dateDOB.Value);
                    cmd.Parameters.Add("@genderEmp", checkgender);
                    cmd.Parameters.Add("@position", cbbPosition.SelectedItem);
                    cmd.Parameters.Add("@IDEmployee", txtIDEmp.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Detail Updated...");
                    conn.Close();
                    showEmployee();
                    refresh();
                }
                else
                {
                    MessageBox.Show("You need to enter all fields correctly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {

            conn = db.GetConnection();
            conn.Open();
            string sql = "update Employee set statusEmp = 0 where IDEmployee = @IDEmployee";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@IDEmployee", txtIDEmp.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete success!");
            //xoa tai khoan cua remployee trong table account
            string sqlDelete = "delete Account where username=@username";
            cmd = new SqlCommand(sqlDelete, conn);
            cmd.Parameters.Add("@username", txtUsername.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            showEmployee();//load lai table sau khi xo thong tin
            refresh();
        }

        //check username employee exist
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            if (checkUpdateOrAdd.Equals("add"))
            {
                if (empList.checkUsername(txtUsername.Text))
                {
                    lblCheckUsername.Text = "";
                    excuteUsername = true;
                }
                else
                {
                    lblCheckUsername.Text = "Username already exists";
                    lblCheckUsername.ForeColor = System.Drawing.Color.Red;
                    excuteUsername = false;
                }
            }

        }
        //check phone
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

            lblCheckPhone.Visible = true;//hien thong bao loi phone
            if (empList.checkPhone(txtPhone.Text))
            {
                lblCheckPhone.Text = "";
                excutePhone = true;
            }
            else
            {
                lblCheckPhone.Text = "Phone number invalid. Ex 0981235432";
                lblCheckPhone.ForeColor = System.Drawing.Color.Red;
                excutePhone = false;
            }

        }
        //check valid email
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmail.Visible = true;//hien thong bao loi email

            if (empList.checkEmail(txtEmail.Text))
            {
                lblEmail.Text = "";
                excuteEmail = true;
            }
            else
            {
                lblEmail.Text = "Email invalid. Ex: hong@gmail.com";
                lblEmail.ForeColor = System.Drawing.Color.Red;
                excuteEmail = false;
            }
        }
        /**
         * search by fullname emp
         * */
        private void btnSearchFullname_Click(object sender, EventArgs e)
        {
            tbEmployee.DataSource = empList.searchByFullnameEmp(txtsSearchFullname.Text);
        }

        /**
         * reload lai trang emp sau khi search or sort
         * */
        private void btnReloadEmp_Click(object sender, EventArgs e)
        {
            showEmployee();
        }

        /**
        * CUSTOMER MANAGEMENT =================================================================================================================================
        * 
        * */

        private void btnRefreshCus_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void tbCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtUsernameCus.Enabled = false;
            txtIDCus.Enabled = false;
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtIDCus.Text = tbCustomer.Rows[index].Cells["IDCustomer"].Value.ToString().Trim();
                txtFullNameCus.Text = tbCustomer.Rows[index].Cells["fullnameCus"].Value.ToString().Trim();
                txtPhoneCus.Text = tbCustomer.Rows[index].Cells["phoneCus"].Value.ToString().Trim();
                txtEmailCus.Text = tbCustomer.Rows[index].Cells["emailCus"].Value.ToString().Trim();
                dateDOBCus.Value = Convert.ToDateTime(tbCustomer.Rows[index].Cells["DOBCus"].Value.ToString());
                if (tbCustomer.Rows[index].Cells["genderCus"].Value.ToString().Equals("Female"))
                {
                    radioFemailCus.Select();
                }
                else
                {
                    radioMaleCus.Select();
                }
                txtUsernameCus.Text = tbCustomer.Rows[index].Cells["usernameCus"].Value.ToString().Trim();



            }

        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            conn = db.GetConnection();
            conn.Open();
            string sql = "update Customer set statusCus = 0 where IDCustomer = @IDCustomer";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@IDCustomer", txtIDCus.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete success!");
            //xoa tai khoan cua remployee trong table account
            string sqlDelete = "delete Account where username=@username";
            cmd = new SqlCommand(sqlDelete, conn);
            cmd.Parameters.Add("@username", txtUsernameCus.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            showCustomer();//load lai table sau khi xo thong tin
            refresh();
        }
        /**
         * reload lai trang cus sau khi search or sort
         * */
        private void btnReloadCus_Click(object sender, EventArgs e)
        {
            showCustomer();
        }
        /**
         * search username fullname customer
         * */
        private void btnSearrchFullnameCus_Click(object sender, EventArgs e)
        {
            tbCustomer.DataSource = cusList.searchByFullnameCus(txtSearchFullnameCus.Text);
        }

       
    }
}
