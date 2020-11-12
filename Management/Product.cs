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

        public Product()
        {
            InitializeComponent();
            pro = new productsList();
            db = new DBConectionManager();
        }

        public void showProduct()
        {
            DataTable dt = pro.getProduct();
            tbProduct.DataSource = dt;
        }



        //lay caegory vao combobox
        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOFFEEDataSet4.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cOFFEEDataSet4.Customer);
            // TODO: This line of code loads data into the 'cOFFEEDataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.cOFFEEDataSet4.Employee);
            // TODO: This line of code loads data into the 'cOFFEEDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cOFFEEDataSet2.Product);
            txtIDPro.Enabled = false;
            // TODO: This line of code loads data into the 'cOFFEEDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cOFFEEDataSet2.Product);
            txtIDPro.Enabled = true;
            conn = db.GetConnection();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="Select * from category";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbbCategory.Items.Add(dr["nameCategory"].ToString());

            }
            conn.Close();


            showProduct();
        }
        public void refresh()
        {
            txtIDPro.Text = "";
            txtDescripton.Text = "";
            txtNamePro.Text = "";
            txtPrice.Text = "";
            cbbAvailable.Text = "";
            cbbCategory.Text = "";
            txtURL.Text = "";
            cbbAvailable.Text = "";
            pictureBox.Image = null;
            //panelImage
           
        }

        

       

       
        private void tbProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtIDPro.Enabled = false;
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtIDPro.Text = tbProduct.Rows[index].Cells["IDProduct"].Value.ToString().Trim();
                txtIDPro.Enabled = false;
                txtNamePro.Text = tbProduct.Rows[index].Cells["nameProduct"].Value.ToString().Trim();
                cbbAvailable.Text = tbProduct.Rows[index].Cells["available"].Value.ToString().Trim();
                txtPrice.Text = tbProduct.Rows[index].Cells["price"].Value.ToString().Trim();
                txtDescripton.Text = tbProduct.Rows[index].Cells["description"].Value.ToString().Trim();
                cbbCategory.SelectedIndex = int.Parse(tbProduct.Rows[index].Cells["IDCategory"].Value.ToString().Trim()) - 1;//-1 de lay dc dung vi tri trong combobox
                txtURL.Text = tbProduct.Rows[index].Cells["imageUrl"].Value.ToString().Trim();
                Byte[] imgData = new Byte[0];
                imgData = (Byte[])tbProduct.Rows[index].Cells["photo"].Value;
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

        private void cbbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            indexCategory = cbbCategory.SelectedIndex + 1;//lay chi so cua category khi chon vào combobox
        }

        private void bntAdd_Click_1(object sender, EventArgs e)
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
            cmd.Parameters.Add("@nameProduct", txtNamePro.Text);
            cmd.Parameters.Add("@available", cbbAvailable.Text);
            cmd.Parameters.Add("@imageUrl", txtURL.Text);
            cmd.Parameters.Add("@price", double.Parse(txtPrice.Text));
            cmd.Parameters.Add("@description", txtDescripton.Text);
            cmd.Parameters.Add("@IDCategory", indexCategory);
            cmd.Parameters.Add("@photo", arr);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Product saved");

            SqlCommand loadAgain = new SqlCommand("select * from Product where status = 1 ", conn);
            DataTable dt = new DataTable();
            dt.Load(loadAgain.ExecuteReader());
            tbProduct.DataSource = dt;
            conn.Close();

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
            cmd.Parameters.Add("@available", cbbAvailable.Text);
            cmd.Parameters.Add("@imageUrl", txtURL.Text);
            cmd.Parameters.Add("@price", double.Parse(txtPrice.Text));
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
