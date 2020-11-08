using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace CoffeeOnlineSystem.Models
{
    public class account
    {
        int idUser;
        string phone;
        string email;
        string username;
        string fullname;
        string password;
        string gender;
        string dob;
        int idRole;

       
        [Display(Name = "ID user ")]
        public int IdUser { get => idUser; set => idUser = value; }
        [Display(Name = "Full name")]
        public string Fullname { get => fullname; set => fullname = value; }
        [RegularExpression("^([0]\\d{9})$|^((\\+84)\\d{9})$", ErrorMessage =  "Please enter phone e.g 0982626654 or +84984512623")]
        [Display(Name = "Phone")]
        public string Phone { get => phone; set => phone = value; }
        [RegularExpression("^[a-zA-Z0-9]+([.-_][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-_][a-zA-Z0-9]+)*([.-_][a-zA-Z0-9]{2,})+$", ErrorMessage = "Email invalid")]
        [Display(Name = "Emaiil")]
        public string Email { get => email; set => email = value; }
        [Display(Name = "Username")]
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        [Display(Name = "Gender")]
        public string Gender { get => gender; set => gender = value; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Dob { get => dob; set => dob = value; }
        [Display(Name = "ID role")]
        [RegularExpression("^[2]$", ErrorMessage = "Please enter the employee role as 2")]
        public int IdRole { get => idRole; set => idRole = value; }

       

        public account()
        {
        }

        public account(int idUser, string phone, string email, string username, string fullname, string password, string gender, string dob, int idRole)
        {
            this.idUser = idUser;
            this.phone = phone;
            this.email = email;
            this.username = username;
            this.fullname = fullname;
            this.password = password;
            this.gender = gender;
            this.dob = dob;
            this.idRole = idRole;
        }
    }

    //CUSTOMER
    class customertList
    {
        DBConection db;
        public customertList()
        {
            db = new DBConection();
        }
        public List<account> getCustomer(int? id)
        {
            string sql;
            if (id == null)
            {
                sql = "select * from account where IDRole= '1' ";
            }
            else
            {
                sql = "select * from account where IDUser='" + id +"'";
            }
            List<account> cusList = new List<account>();
            DataTable dt = new DataTable();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            account temp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                temp = new account();
                temp.IdUser = Convert.ToInt32(dt.Rows[i]["IDUser"].ToString());
                temp.Fullname = dt.Rows[i]["fullname"].ToString();
                temp.Username = dt.Rows[i]["username"].ToString();
                temp.Password = dt.Rows[i]["password"].ToString();
                temp.Phone = dt.Rows[i]["phone"].ToString();
                temp.Email = dt.Rows[i]["email"].ToString();
                temp.Gender = dt.Rows[i]["gender"].ToString();
                temp.Dob = dt.Rows[i]["DOB"].ToString();
                temp.IdRole = Convert.ToInt32(dt.Rows[i]["IDRole"].ToString());
                cusList.Add(temp);
            }
            return cusList;
        }
       
        public void delete(int id)
        {
            string sql = "delete account where IDUser='" + id + "'";
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

    }

    //EMPLOYEE
    class employeeList
    {
        DBConection db;
        public employeeList()
        {
            db = new DBConection();
        }
        public List<account> getEmployee(int? id)
        {
            string sql;
            if (id == null)
            {
                sql = "select * from account where IDRole= '2' ";
            }
            else
            {
                sql = "select * from account where IDUser='" + id + "'";
            }
            List<account> cusList = new List<account>();
            DataTable dt = new DataTable();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            account temp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                temp = new account();
                temp.IdUser = Convert.ToInt32(dt.Rows[i]["IDUser"].ToString());
                temp.Fullname = dt.Rows[i]["fullname"].ToString();
                temp.Username = dt.Rows[i]["username"].ToString();
                temp.Password = dt.Rows[i]["password"].ToString();
                temp.Phone = dt.Rows[i]["phone"].ToString();
                temp.Email = dt.Rows[i]["email"].ToString();
                temp.Gender = dt.Rows[i]["gender"].ToString();
                temp.Dob = dt.Rows[i]["DOB"].ToString();
                temp.IdRole = Convert.ToInt32(dt.Rows[i]["IDRole"].ToString());
                cusList.Add(temp);
            }
            return cusList;
        }

        public void addEmp(account stu)
        {
            string sql = "insert into account( phone, email,username,password,gender, fullname,IDRole,DOB) values(N'" + stu.Phone + "',N'" + stu.Email + "'," +
                "N'" + stu.Username + "',N'" + stu.Password + "',N'" + stu.Gender + "',N'" + stu.Fullname + "',N'" + stu.IdRole + "',N'" + stu.Dob + "')";
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void update(account stu)
        {
            string sql = "update account set phone= N'" + stu.Phone + "',email=N'" + stu.Email + "'," +
               "username= N'" + stu.Username + "',password=N'" + stu.Password + "',gender=N'" + stu.Gender + "',fullname=N'" + stu.Fullname + "',IDRole=N'" + stu.IdRole + "',DOB=N'" + stu.Dob + "' where IDUser='" + stu.IdUser + "' ";
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }






    }
}