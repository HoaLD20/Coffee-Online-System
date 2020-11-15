
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Management.Models
{
    public class products
    {
        int idProduct;
        string nameProduct;
        string image;
        int inventoryProduct;
        double price;
        string description;
        int idCatogory;
        string photo;
        int stutas;
        public products()
        {
        }

        public products(int idProduct, string nameProduct, string image, int inventoryProduct, double price, string description, int idCatogory, string photo)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.image = image;
            this.inventoryProduct = inventoryProduct;
            this.price = price;
            this.description = description;
            this.idCatogory = idCatogory;
            this.photo = photo;
        }

        public products(int idProduct, string nameProduct, string image, int inventoryProduct, double price, string description, int idCatogory, string photo, int stutas)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.image = image;
            this.inventoryProduct = inventoryProduct;
            this.price = price;
            this.description = description;
            this.idCatogory = idCatogory;
            this.photo = photo;
            this.Stutas = stutas;
        }

        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Image { get => image; set => image = value; }
        public int InventoryProduct { get => inventoryProduct; set => inventoryProduct = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public int IdCatogory { get => idCatogory; set => idCatogory = value; }
        public string Photo { get => photo; set => photo = value; }
        public int Stutas { get => stutas; set => stutas = value; }
    }
    class productsList
    {
        DBConectionManager db;
        SqlCommand cmd;
        SqlConnection conn;
        public productsList()
        {
            db = new DBConectionManager();
        }
        public DataTable getProduct()
        {
            string sql;
            sql = "select * from Product where status = 1";

            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqldataAdapter thuc hien đở dữ liệu và data set, cập nhật database, SqlCommand thực thi câu lệnh sql insert update delete
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//Fill dung để đổ dữ liệu vào dataSet
            con.Close();
            return dt;
        }
        /**
         * search by name product
         * 
         * */
        public DataTable searchByNameProduct(string name)
        {
            string sql;
            sql = "select * from Product where nameProduct like'%"+name+"%'";
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//SqldataAdapter thuc hien đở dữ liệu và data set, cập nhật database, SqlCommand thực thi câu lệnh sql insert update delete
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//Fill dung để đổ dữ liệu vào dataSet
            con.Close();
            return dt;
        }
        /**
        * search by category
        * 
        * */
        public DataTable searchByCategory(int category)
        {
            string sql;
            sql = "select * from Product where IDCategory like'" + category + "'";
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
