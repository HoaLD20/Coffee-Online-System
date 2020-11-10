using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        int idDetail;
        public products(int idProduct, string nameProduct, string image, int inventoryProduct, double price, string description, int iDCatogory, int idDetail)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.image = image;
            this.inventoryProduct = inventoryProduct;
            this.price = price;
            this.description = description;
            idCatogory = iDCatogory;
            this.idDetail = idDetail;
        }

        public products()
        {
        }

        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Image { get => image; set => image = value; }
        public int InventoryProduct { get => inventoryProduct; set => inventoryProduct = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }

        public int IDCatogory { get => idCatogory; set => idCatogory = value; }
        public int IDDetail { get => idDetail; set => idDetail = value; }

    }
    class productsList
    {
        DBConection db;
        SqlCommand cmd;
        SqlConnection conn;
        public productsList()
        {
            db = new DBConection();
        }
        public DataTable getProduct()
        {
            string sql;
            sql = "select * from products";
            List<products> proList = new List<products>();

            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public bool addProduct(products pro)
        {


            string sql = "insert into products(nameProduct, available,image, price,descripttion,IDCategory,IDDetail) values (@nameProduct,@available,@image,@price,@descripttion,@IDCategory,@IDDetail)";
            //tao ket noi toi sql
            conn = db.GetConnection();

            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@nameProduct", SqlDbType.NVarChar).Value = pro.NameProduct;
                cmd.Parameters.Add("@available", SqlDbType.NVarChar).Value = pro.InventoryProduct;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar).Value = pro.Image;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = pro.Price;
                cmd.Parameters.Add("@descripttion", SqlDbType.Float).Value = pro.Description;
                cmd.Parameters.Add("@IDCategory", SqlDbType.Int).Value = pro.IDCatogory;
                cmd.Parameters.Add("@IDDetail", SqlDbType.Int).Value = pro.IDDetail;
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
            string sql = "delete products where IDProduct=@IDProduct";
            SqlConnection con = db.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@IDProduct", SqlDbType.NVarChar).Value = pro.IdProduct;
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
            string sql = "update products set nameProduct=@nameProduct, available=@available,image=@image, price=@price,descripttion=@descripttion,IDCategory=@IDCategory,IDDetail=@IDDetail where IDProduct=@IDProduct";
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
