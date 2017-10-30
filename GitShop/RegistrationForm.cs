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
    public partial class RegistrationForm : Form
    {
        private string userName;
        public string UserName { get { return userName; } set { userName = value; } }

        private string userPassword;
        public string UserPassword { get { return userPassword; } set { userPassword = value; } }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btn_Cencel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Enter all data !!!");
            }
            else if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Enter all data !!!");

            }
            else
            {
                userName = txt_Name.Text;
                userPassword = txt_Password.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
