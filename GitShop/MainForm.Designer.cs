namespace GitShop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.myMenuStrip = new System.Windows.Forms.MenuStrip();
            this.myMenuStrip_Actions = new System.Windows.Forms.ToolStripMenuItem();
            this.myMenuStrip_Actions_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.myMenuStrip_Actions_Registration = new System.Windows.Forms.ToolStripMenuItem();
            this.myTabControl = new System.Windows.Forms.TabControl();
            this.myTabControl_UsersPage = new System.Windows.Forms.TabPage();
            this.myTabControl_ProductsPage = new System.Windows.Forms.TabPage();
            this.btn_ChangeUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ChangeProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.myToolStrip = new System.Windows.Forms.ToolStrip();
            this.myToolStrip_UserStatusInfo = new System.Windows.Forms.ToolStripLabel();
            this.myToolStrip_TimeNow = new System.Windows.Forms.ToolStripLabel();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdcutPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myMenuStrip.SuspendLayout();
            this.myTabControl.SuspendLayout();
            this.myTabControl_UsersPage.SuspendLayout();
            this.myTabControl_ProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.myToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMenuStrip
            // 
            this.myMenuStrip.BackColor = System.Drawing.Color.Navy;
            this.myMenuStrip.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMenuStrip_Actions});
            this.myMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.myMenuStrip.Name = "myMenuStrip";
            this.myMenuStrip.Size = new System.Drawing.Size(850, 51);
            this.myMenuStrip.TabIndex = 0;
            // 
            // myMenuStrip_Actions
            // 
            this.myMenuStrip_Actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMenuStrip_Actions_Login,
            this.myMenuStrip_Actions_Registration});
            this.myMenuStrip_Actions.ForeColor = System.Drawing.Color.DarkOrange;
            this.myMenuStrip_Actions.Name = "myMenuStrip_Actions";
            this.myMenuStrip_Actions.Size = new System.Drawing.Size(120, 47);
            this.myMenuStrip_Actions.Text = "Actions";
            // 
            // myMenuStrip_Actions_Login
            // 
            this.myMenuStrip_Actions_Login.BackColor = System.Drawing.Color.SkyBlue;
            this.myMenuStrip_Actions_Login.ForeColor = System.Drawing.Color.DarkOrange;
            this.myMenuStrip_Actions_Login.Name = "myMenuStrip_Actions_Login";
            this.myMenuStrip_Actions_Login.Size = new System.Drawing.Size(249, 48);
            this.myMenuStrip_Actions_Login.Text = "Login";
            // 
            // myMenuStrip_Actions_Registration
            // 
            this.myMenuStrip_Actions_Registration.BackColor = System.Drawing.Color.SkyBlue;
            this.myMenuStrip_Actions_Registration.ForeColor = System.Drawing.Color.DarkOrange;
            this.myMenuStrip_Actions_Registration.Name = "myMenuStrip_Actions_Registration";
            this.myMenuStrip_Actions_Registration.Size = new System.Drawing.Size(249, 48);
            this.myMenuStrip_Actions_Registration.Text = "Registration";
            // 
            // myTabControl
            // 
            this.myTabControl.Controls.Add(this.myTabControl_UsersPage);
            this.myTabControl.Controls.Add(this.myTabControl_ProductsPage);
            this.myTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabControl.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTabControl.Location = new System.Drawing.Point(0, 51);
            this.myTabControl.Name = "myTabControl";
            this.myTabControl.SelectedIndex = 0;
            this.myTabControl.Size = new System.Drawing.Size(850, 366);
            this.myTabControl.TabIndex = 1;
            // 
            // myTabControl_UsersPage
            // 
            this.myTabControl_UsersPage.BackColor = System.Drawing.Color.Tan;
            this.myTabControl_UsersPage.Controls.Add(this.btn_ChangeUser);
            this.myTabControl_UsersPage.Controls.Add(this.btn_DeleteUser);
            this.myTabControl_UsersPage.Controls.Add(this.btn_AddUser);
            this.myTabControl_UsersPage.Controls.Add(this.dgv_Users);
            this.myTabControl_UsersPage.Location = new System.Drawing.Point(4, 40);
            this.myTabControl_UsersPage.Name = "myTabControl_UsersPage";
            this.myTabControl_UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTabControl_UsersPage.Size = new System.Drawing.Size(842, 322);
            this.myTabControl_UsersPage.TabIndex = 0;
            this.myTabControl_UsersPage.Text = "Users";
            // 
            // myTabControl_ProductsPage
            // 
            this.myTabControl_ProductsPage.BackColor = System.Drawing.Color.Tan;
            this.myTabControl_ProductsPage.Controls.Add(this.btn_ChangeProduct);
            this.myTabControl_ProductsPage.Controls.Add(this.btn_DeleteProduct);
            this.myTabControl_ProductsPage.Controls.Add(this.btn_AddProduct);
            this.myTabControl_ProductsPage.Controls.Add(this.dgv_Products);
            this.myTabControl_ProductsPage.Location = new System.Drawing.Point(4, 40);
            this.myTabControl_ProductsPage.Name = "myTabControl_ProductsPage";
            this.myTabControl_ProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTabControl_ProductsPage.Size = new System.Drawing.Size(842, 322);
            this.myTabControl_ProductsPage.TabIndex = 1;
            this.myTabControl_ProductsPage.Text = "Products";
            // 
            // btn_ChangeUser
            // 
            this.btn_ChangeUser.BackColor = System.Drawing.Color.Navy;
            this.btn_ChangeUser.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_ChangeUser.Location = new System.Drawing.Point(642, 206);
            this.btn_ChangeUser.Name = "btn_ChangeUser";
            this.btn_ChangeUser.Size = new System.Drawing.Size(192, 70);
            this.btn_ChangeUser.TabIndex = 7;
            this.btn_ChangeUser.Text = "Change user";
            this.btn_ChangeUser.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.Navy;
            this.btn_DeleteUser.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_DeleteUser.Location = new System.Drawing.Point(642, 106);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(192, 70);
            this.btn_DeleteUser.TabIndex = 6;
            this.btn_DeleteUser.Text = "Delete user";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.Navy;
            this.btn_AddUser.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_AddUser.Location = new System.Drawing.Point(642, 6);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(192, 70);
            this.btn_AddUser.TabIndex = 5;
            this.btn_AddUser.Text = "Add user";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            // 
            // dgv_Users
            // 
            this.dgv_Users.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserLastName,
            this.UserRole});
            this.dgv_Users.Location = new System.Drawing.Point(8, 6);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.RowTemplate.Height = 24;
            this.dgv_Users.Size = new System.Drawing.Size(612, 270);
            this.dgv_Users.TabIndex = 4;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.Width = 50;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.Width = 120;
            // 
            // UserLastName
            // 
            this.UserLastName.HeaderText = "Last Name";
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Width = 160;
            // 
            // UserRole
            // 
            this.UserRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRole.HeaderText = "Role";
            this.UserRole.Name = "UserRole";
            // 
            // btn_ChangeProduct
            // 
            this.btn_ChangeProduct.BackColor = System.Drawing.Color.Navy;
            this.btn_ChangeProduct.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_ChangeProduct.Location = new System.Drawing.Point(642, 206);
            this.btn_ChangeProduct.Name = "btn_ChangeProduct";
            this.btn_ChangeProduct.Size = new System.Drawing.Size(192, 70);
            this.btn_ChangeProduct.TabIndex = 11;
            this.btn_ChangeProduct.Text = "Change product";
            this.btn_ChangeProduct.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.BackColor = System.Drawing.Color.Navy;
            this.btn_DeleteProduct.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_DeleteProduct.Location = new System.Drawing.Point(642, 106);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(192, 70);
            this.btn_DeleteProduct.TabIndex = 10;
            this.btn_DeleteProduct.Text = "Delete product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.Navy;
            this.btn_AddProduct.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_AddProduct.Location = new System.Drawing.Point(642, 6);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(192, 70);
            this.btn_AddProduct.TabIndex = 9;
            this.btn_AddProduct.Text = "Add product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            // 
            // dgv_Products
            // 
            this.dgv_Products.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductCategory,
            this.ProdcutPrice});
            this.dgv_Products.Location = new System.Drawing.Point(8, 6);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowTemplate.Height = 24;
            this.dgv_Products.Size = new System.Drawing.Size(612, 270);
            this.dgv_Products.TabIndex = 8;
            // 
            // myToolStrip
            // 
            this.myToolStrip.BackColor = System.Drawing.Color.Navy;
            this.myToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myToolStrip.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myToolStrip_UserStatusInfo,
            this.myToolStrip_TimeNow});
            this.myToolStrip.Location = new System.Drawing.Point(0, 381);
            this.myToolStrip.Name = "myToolStrip";
            this.myToolStrip.Size = new System.Drawing.Size(850, 36);
            this.myToolStrip.TabIndex = 3;
            // 
            // myToolStrip_UserStatusInfo
            // 
            this.myToolStrip_UserStatusInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.myToolStrip_UserStatusInfo.Name = "myToolStrip_UserStatusInfo";
            this.myToolStrip_UserStatusInfo.Size = new System.Drawing.Size(156, 33);
            this.myToolStrip_UserStatusInfo.Text = "UserStatusInfo";
            // 
            // myToolStrip_TimeNow
            // 
            this.myToolStrip_TimeNow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.myToolStrip_TimeNow.ForeColor = System.Drawing.Color.DarkOrange;
            this.myToolStrip_TimeNow.Name = "myToolStrip_TimeNow";
            this.myToolStrip_TimeNow.Size = new System.Drawing.Size(111, 33);
            this.myToolStrip_TimeNow.Text = "00:00:00";
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 120;
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Width = 160;
            // 
            // ProdcutPrice
            // 
            this.ProdcutPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdcutPrice.HeaderText = "Price";
            this.ProdcutPrice.Name = "ProdcutPrice";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(850, 417);
            this.Controls.Add(this.myToolStrip);
            this.Controls.Add(this.myTabControl);
            this.Controls.Add(this.myMenuStrip);
            this.MainMenuStrip = this.myMenuStrip;
            this.Name = "MainForm";
            this.Text = "Shop";
            this.myMenuStrip.ResumeLayout(false);
            this.myMenuStrip.PerformLayout();
            this.myTabControl.ResumeLayout(false);
            this.myTabControl_UsersPage.ResumeLayout(false);
            this.myTabControl_ProductsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.myToolStrip.ResumeLayout(false);
            this.myToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip myMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem myMenuStrip_Actions;
        private System.Windows.Forms.ToolStripMenuItem myMenuStrip_Actions_Login;
        private System.Windows.Forms.ToolStripMenuItem myMenuStrip_Actions_Registration;
        private System.Windows.Forms.TabControl myTabControl;
        private System.Windows.Forms.TabPage myTabControl_UsersPage;
        private System.Windows.Forms.TabPage myTabControl_ProductsPage;
        private System.Windows.Forms.Button btn_ChangeUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.Button btn_ChangeProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.ToolStrip myToolStrip;
        private System.Windows.Forms.ToolStripLabel myToolStrip_UserStatusInfo;
        private System.Windows.Forms.ToolStripLabel myToolStrip_TimeNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdcutPrice;
    }
}

