
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeOnlineSystem.Models
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
        public products(int idProduct, string nameProduct, string image, int inventoryProduct, double price, string description, int iDCatogory)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.image = image;
            this.inventoryProduct = inventoryProduct;
            this.price = price;
            this.description = description;
            idCatogory = iDCatogory;
        }

        public products()
        {
        }

        [Display(Name = "NO.")]
        public int IdProduct { get => idProduct; set => idProduct = value; }

        [Required(ErrorMessage = "Please Enter Name Product e.g. coffee")]
        [Display(Name = "Name")]
        [StringLength(30, MinimumLength = 3)]
        public string NameProduct { get => nameProduct; set => nameProduct = value; }

        [Required(ErrorMessage = "Please choose image")]
        [Display(Name = "Image")]
        public string Image { get => image; set => image = value; }

        [Display(Name = "Available")]
        [Range(1, 1000)]
        public int InventoryProduct { get => inventoryProduct; set => inventoryProduct = value; }

        [Display(Name = "Price")]
        [Range(1, 200)]
        public double Price { get => price; set => price = value; }

        [Display(Name = "Description:")]
        [StringLength(500)]
        public string Description { get => description; set => description = value; }

        [Display(Name = "ID Category:")]
        [Range(1, 5)]
        public int IDCatogory { get => idCatogory; set => idCatogory = value; }

    }
    class productsList
    {
        DBConection db;
        public productsList()
        {
            db = new DBConection();
        }
        public List<products> getProduct(int? id)
        {
            string sql;
            if (id == null)
            {
                sql = "select * from products";
            }
            else
            {
                sql = "select * from products where IDProduct=" + id;
            }
            List<products> proList = new List<products>();
            DataTable dt = new DataTable();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            products temp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp = new products();
                temp.IdProduct = Convert.ToInt32(dt.Rows[i]["IDProduct"].ToString());
                temp.NameProduct = dt.Rows[i]["nameProduct"].ToString();
                temp.InventoryProduct = Convert.ToInt32(dt.Rows[i]["inventoryNumber"].ToString());
                temp.Image = dt.Rows[i]["image"].ToString();
                temp.Price = Convert.ToDouble(dt.Rows[i]["price"].ToString());
                temp.Description = dt.Rows[i]["descripttion"].ToString();
                temp.IDCatogory = Convert.ToInt32(dt.Rows[i]["IDCategory"].ToString());
                proList.Add(temp);
            }
            return proList;
        }
        public void addProduct(products stu)
        {
            string sql = "insert into products(nameProduct, inventoryNumber, image,price,descripttion,IDCategory) values(N'" + stu.NameProduct + "',N'" + stu.InventoryProduct + "'," +
                "N'" + stu.Image + "',N'" + stu.Price + "',N'" + stu.Description + "',N'" + stu.IDCatogory + "')";
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void delete(int id)
        {
            string sql = "delete products where IDProduct='" + id + "'";
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public List<products> update(int? id)
        {
            string sql = "select * from products where IDProduct=" + id;

            List<products> proList = new List<products>();
            DataTable dt = new DataTable();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            products temp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp = new products();
                temp.IdProduct = Convert.ToInt32(dt.Rows[i]["IDProduct"].ToString());
                temp.NameProduct = dt.Rows[i]["nameProduct"].ToString();
                temp.InventoryProduct = Convert.ToInt32(dt.Rows[i]["inventoryNumber"].ToString());
                temp.Image = dt.Rows[i]["image"].ToString();
                temp.Price = Convert.ToDouble(dt.Rows[i]["price"].ToString());
                temp.Description = dt.Rows[i]["descripttion"].ToString();
                temp.IDCatogory = Convert.ToInt32(dt.Rows[i]["IDCategory"].ToString());
                proList.Add(temp);
            }
            return proList;
        }

        public void update(products stu)
        {
            string sql = "update products set nameProduct= N'" + stu.NameProduct + "',inventoryNumber=N'" + stu.InventoryProduct + "'," +
               "image= N'" + stu.Image + "',price=N'" + stu.Price + "',descripttion=N'" + stu.Description + "',IDCategory=N'" + stu.IDCatogory + "' where IDProduct='" + stu.IdProduct + "' ";
            SqlConnection con = db.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

    }
}