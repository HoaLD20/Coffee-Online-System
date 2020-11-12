
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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


        public bool addProduct(products pro)
        {


            string sql = "insert into Product(nameProduct, available,imageUrl, price,description,IDCategory, photo) values (@nameProduct,@available,@imageUrl,@price,@description,@IDCategory,@photo)";
            //tao ket noi toi sql
            conn = db.GetConnection();

            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@nameProduct", SqlDbType.NVarChar).Value = pro.NameProduct;
                cmd.Parameters.Add("@available", SqlDbType.NVarChar).Value = pro.InventoryProduct;
                cmd.Parameters.Add("@imageUrl", SqlDbType.NVarChar).Value = pro.Image;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = pro.Price;
                cmd.Parameters.Add("@description", SqlDbType.Float).Value = pro.Description;
                cmd.Parameters.Add("@IDCategory", SqlDbType.Int).Value = pro.IdCatogory;
                cmd.Parameters.Add("@photo", SqlDbType.Image).Value = pro.Photo;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        public bool delete(products pro)
        {
            string sql = "delete Product where IDProduct=@IDProduct";
            cmd = new SqlCommand(sql, conn);
            
            SqlConnection con = db.GetConnection();
            try
            {                
                conn.Open();
                cmd.Parameters.Add("@IDProduct", SqlDbType.Int).Value = pro.IdProduct;
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;

        }
        public void update(products pro)
        {
            string sql = "update Product set nameProduct=@nameProduct, available=@available,imageUrl=@imageUrl, price=@price,description=@description,IDCategory=@IDCategory,photo=@photo where IDProduct=@IDProduct";
            //tao ket noi toi sql
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
    }
}
