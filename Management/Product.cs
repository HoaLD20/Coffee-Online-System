using Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Product : Form
    {
        productsList pro;
        public Product()
        {
            InitializeComponent();
             pro = new productsList();
        }

        public void showProduct()
        {
            DataTable dt = pro.getProduct();
            tbProduct.DataSource = dt;
        }



       
        private void Product_Load(object sender, EventArgs e)
        {
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
            //panelImage
            txtIDPro.Enabled = true;
        }
    }
}
