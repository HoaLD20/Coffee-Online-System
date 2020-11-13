using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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


        
    }
}
