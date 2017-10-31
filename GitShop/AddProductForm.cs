using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitShop
{
    public partial class AddProductForm : Form
    {
        private string productName;
        public string ProductName { get { return productName; } set { productName = value; } }

        private string productCategory;
        public string ProductCategory { get { return productCategory; } set { productCategory = value; } }

        private string productPrice;
        public string ProductPrice { get { return productPrice; } set { productPrice = value; } }

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Enter all data !!!");
            }
            else if (string.IsNullOrEmpty(txt_Category.Text))
            {
                MessageBox.Show("Enter all data !!!");

            }
            else if (string.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Enter all data !!!");

            }
            else
            {
                productName = txt_Name.Text;
                productCategory = txt_Category.Text;
                productPrice = txt_Price.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cencel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
