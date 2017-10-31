namespace GitShop
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cencel = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_Category = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cencel
            // 
            this.btn_Cencel.BackColor = System.Drawing.Color.Navy;
            this.btn_Cencel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cencel.ForeColor = System.Drawing.Color.Orange;
            this.btn_Cencel.Location = new System.Drawing.Point(19, 159);
            this.btn_Cencel.Name = "btn_Cencel";
            this.btn_Cencel.Size = new System.Drawing.Size(94, 37);
            this.btn_Cencel.TabIndex = 17;
            this.btn_Cencel.Text = "Cencel";
            this.btn_Cencel.UseVisualStyleBackColor = false;
            this.btn_Cencel.Click += new System.EventHandler(this.btn_Cencel_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.Navy;
            this.btn_AddProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.Orange;
            this.btn_AddProduct.Location = new System.Drawing.Point(147, 159);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(126, 37);
            this.btn_AddProduct.TabIndex = 16;
            this.btn_AddProduct.Text = "Add product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Category.Location = new System.Drawing.Point(126, 60);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(148, 32);
            this.txt_Category.TabIndex = 15;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Name.Location = new System.Drawing.Point(126, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(148, 32);
            this.txt_Name.TabIndex = 14;
            // 
            // lb_Category
            // 
            this.lb_Category.AutoSize = true;
            this.lb_Category.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Category.ForeColor = System.Drawing.Color.Navy;
            this.lb_Category.Location = new System.Drawing.Point(12, 60);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(101, 33);
            this.lb_Category.TabIndex = 13;
            this.lb_Category.Text = "Category";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Name.ForeColor = System.Drawing.Color.Navy;
            this.lb_Name.Location = new System.Drawing.Point(12, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(70, 33);
            this.lb_Name.TabIndex = 12;
            this.lb_Name.Text = "Name";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Price.Location = new System.Drawing.Point(126, 112);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(148, 32);
            this.txt_Price.TabIndex = 19;
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Price.ForeColor = System.Drawing.Color.Navy;
            this.lb_Price.Location = new System.Drawing.Point(12, 112);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(63, 33);
            this.lb_Price.TabIndex = 18;
            this.lb_Price.Text = "Price";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.btn_Cencel);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_Category);
            this.Controls.Add(this.lb_Name);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "AddProductForm";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cencel;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Category;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lb_Price;
    }
}