using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Models
{
    class Customer
    {
        int IDCustomer, status;
        string fullname, phone, email, gender, username;
        string DOB;

        public Customer()
        {
        }

        public Customer(int iDCustomer, int status, string fullname, string phone, string email, string gender, string username, string dOB)
        {
            IDCustomer = iDCustomer;
            this.status = status;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
            this.username = username;
            DOB = dOB;
        }

        public int IDCustomer1 { get => IDCustomer; set => IDCustomer = value; }
        public int Status { get => status; set => status = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Username { get => username; set => username = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
    }
    class CustomerList
    {
        DBConectionManager db;
        SqlCommand cmd;
        SqlConnection conn;
        public CustomerList()
        {
            db = new DBConectionManager();
        }
        public DataTable getCustomer()
        {
            string sql;
            sql = "select * from Customer where statusCus = 1";

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
