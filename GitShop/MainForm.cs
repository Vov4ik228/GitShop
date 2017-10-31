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
    public partial class MainForm : Form
    {
        private bool IsLogged = false;
        private Entities.User user;
        private Timer _timerUpdateTime = new Timer();
        Entities.EFContext _context = new Entities.EFContext();
        public MainForm()
        {
            InitializeComponent();
            myToolStrip_TimeNow.Text = DateTime.Now.ToLongTimeString();
            myToolStrip_UserStatusInfo.Text = "Login or registration please !!!";
            myToolStrip_UserStatusInfo.ForeColor = Color.Red;
            _timerUpdateTime.Enabled = true;
            _timerUpdateTime.Interval = 1000;
            _timerUpdateTime.Tick += TimerUpdateTime;

            dgv_Products.Enabled = false;
            btn_AddProduct.Enabled = false;
            btn_DeleteProduct.Enabled = false;
            btn_ChangeProduct.Enabled = false;

            dgv_Users.Enabled = false;
            btn_AddUser.Enabled = false;
            btn_DeleteUser.Enabled = false;
            btn_ChangeUser.Enabled = false;

            myMenuStrip_Actions_Exit.Enabled = false;
        }

        private void TimerUpdateTime(object sender, EventArgs e)
        {
            myToolStrip_TimeNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void myMenuStrip_Actions_Login_Click(object sender, EventArgs e)
        {
            LoginForm dlg = new LoginForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                user = _context.Users.SingleOrDefault(u => u.Name == dlg.UserName && u.Password == dlg.UserPassword);
                if (user != null)
                {
                    if (IsLogged == false)
                    {
                        if (user.Role == "admin")
                        {
                            dgv_Products.Enabled = true;
                            btn_AddProduct.Enabled = true;
                            btn_DeleteProduct.Enabled = true;
                            btn_ChangeProduct.Enabled = true;

                            dgv_Users.Enabled = true;
                            btn_AddUser.Enabled = true;
                            btn_DeleteUser.Enabled = true;
                            btn_ChangeUser.Enabled = true;

                            myToolStrip_UserStatusInfo.Text = "You are logged in as admin !!!";
                            myToolStrip_UserStatusInfo.ForeColor = Color.Green;
                            IsLogged = true;
                            myMenuStrip_Actions_Login.Enabled = false;
                            myMenuStrip_Actions_Registration.Enabled = false;
                            myMenuStrip_Actions_Exit.Enabled = true;
                            UpdateProdcuts();
                            UpdateUsers();
                        }
                        if (user.Role == "user")
                        {
                            btn_AddProduct.Enabled = true;
                            myToolStrip_UserStatusInfo.Text = "You are logged in as user !!!";
                            myToolStrip_UserStatusInfo.ForeColor = Color.Yellow;
                            IsLogged = true;
                            myMenuStrip_Actions_Login.Enabled = false;
                            myMenuStrip_Actions_Registration.Enabled = false;
                            myMenuStrip_Actions_Exit.Enabled = true;
                            UpdateProdcuts();
                        }
                    }
                    else
                    {
                        myToolStrip_UserStatusInfo.Text = "You are already logged in !!!";
                        myToolStrip_UserStatusInfo.ForeColor = Color.Red;
                    }
                }
                else
                {
                    myToolStrip_UserStatusInfo.Text = "Wrong name or password !!!";
                    myToolStrip_UserStatusInfo.ForeColor = Color.Red;
                }
            }
        }

        private void myMenuStrip_Actions_Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm dlg = new RegistrationForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Entities.User user = new Entities.User();
                    user.Name = dlg.UserName;
                    user.Password = dlg.UserPassword;
                    user.Role = "user";
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    myToolStrip_UserStatusInfo.Text = "You are successfully registered, now you can login !!!";
                    myToolStrip_UserStatusInfo.ForeColor = Color.Green;
                }
                catch
                {
                    myToolStrip_UserStatusInfo.Text = "Error registration !!!";
                    myToolStrip_UserStatusInfo.ForeColor = Color.Red;
                }
            }
        }

        public void UpdateUsers()
        {
            dgv_Users.Rows.Clear();
            foreach (var item in _context.Users.ToList())
            {
                dgv_Users.Rows.Add(item.Id, item.Name, item.Password, item.Role);
            }
        }

        public void UpdateProdcuts()
        {
            dgv_Products.Rows.Clear();
            foreach (var item in _context.Prodcuts.ToList())
            {
                dgv_Products.Rows.Add(item.Id, item.Name, item.Category, item.Price);
            }
        }

        private void myMenuStrip_Actions_Exit_Click(object sender, EventArgs e)
        {
            myToolStrip_UserStatusInfo.Text = "Login or registration please !!!";
            myToolStrip_UserStatusInfo.ForeColor = Color.Red;

            dgv_Products.Enabled = false;
            btn_AddProduct.Enabled = false;
            btn_DeleteProduct.Enabled = false;
            btn_ChangeProduct.Enabled = false;

            dgv_Users.Enabled = false;
            btn_AddUser.Enabled = false;
            btn_DeleteUser.Enabled = false;
            btn_ChangeUser.Enabled = false;

            myMenuStrip_Actions_Login.Enabled = true;
            myMenuStrip_Actions_Registration.Enabled = true;
            myMenuStrip_Actions_Exit.Enabled = false;

            dgv_Products.Rows.Clear();
            dgv_Users.Rows.Clear();
            IsLogged = false;
            user = null;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (this.dgv_Users.SelectedRows.Count == 1)
            {
                int userId = Convert.ToInt32(this.dgv_Users.SelectedRows[0].Cells["UserId"].FormattedValue.ToString());
                if (userId != user.Id)
                {
                    var deletedUser = _context.Users.First(u => u.Id == userId);
                    _context.Users.Remove(deletedUser);
                    _context.SaveChanges();
                    UpdateUsers();

                    myToolStrip_UserStatusInfo.Text = $"You have successfully deleted {deletedUser.Name} !!!";
                    myToolStrip_UserStatusInfo.ForeColor = Color.Green;
                }
                else
                {
                    myToolStrip_UserStatusInfo.Text = "You can not remove yourself !!!";
                    myToolStrip_UserStatusInfo.ForeColor = Color.Red;
                }
            }
            else
            {
                myToolStrip_UserStatusInfo.Text = "Choose one deleted user !!!";
                myToolStrip_UserStatusInfo.ForeColor = Color.Red;
            }
        }
    }
}
