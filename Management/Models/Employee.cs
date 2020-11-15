using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Management.Models
{
    class Employee
    {
        int idEmp;
        string fullname, phone, email, gender, username, position, status;

        public Employee()
        {
        }

        public Employee(int idEmp, string fullname, string phone, string email, string gender, string username, string position, string status)
        {
            this.idEmp = idEmp;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
            this.username = username;
            this.position = position;
            this.status = status;
        }

        public int IdEmp { get => idEmp; set => idEmp = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Username { get => username; set => username = value; }
        public string Position { get => position; set => position = value; }
        public string Status { get => status; set => status = value; }
    }
    class EmployeeList
    {
        DBConectionManager db;
        SqlCommand cmd;
        SqlConnection conn;
        public EmployeeList()
        {
            db = new DBConectionManager();
        }
        public DataTable getEmployee()
        {
            string sql;
            sql = "select * from Employee where statusEmp = 1";

            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqldataAdapter thuc hien đở dữ liệu và data set, cập nhật database, SqlCommand thực thi câu lệnh sql insert update delete
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//Fill dung để đổ dữ liệu vào dataSet
            con.Close();
            return dt;
        }

        //check username employee exist
        public bool checkUsername(string username)
        {
            string sql;
            sql = "select * from Account where username='"+username+"'";
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//Fill dung để đổ dữ liệu vào dataSet
           
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            return true;
            conn.Close();
        }

        //check sdt
        public bool checkPhone(string phone)
        {
            Regex regex = new Regex("^([0]\\d{9})$|^((\\+84)\\d{9})$");
            if (!regex.IsMatch(phone))
            {
                return false;
            }
            return true;
        }
        //valid email        
        public bool checkEmail(string email)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+([.-_][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-_][a-zA-Z0-9]+)*([.-_][a-zA-Z0-9]{2,})+$");
            if (!regex.IsMatch(email))
            {
                return false;
            }
            return true;
        }

        //MD5 pass
       
            public string MD5Hash(string text)
            {
                MD5 md5 = new MD5CryptoServiceProvider();

                //compute hash from the bytes of text  
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

                //get hash result after compute it  
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(result[i].ToString("x2"));
                }

                return strBuilder.ToString();
            }

        /**
        * search by fullname Employee
        * 
        * */
        public DataTable searchByFullnameEmp(string name) 
        { 
            string sql;
            sql = "select * from Employee where fullnameEmp like'%" + name + "%' or usernameEmp like '%"+name+"%'";
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqldataAdapter thuc hien đở dữ liệu và data set, cập nhật database, SqlCommand thực thi câu lệnh sql insert update delete
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//Fill dung để đổ dữ liệu vào dataSet
            con.Close();
            return dt;
        }
    }
}
