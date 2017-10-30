namespace GitShop
{
    partial class RegistrationForm
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_Cencel = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Password.Location = new System.Drawing.Point(166, 72);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(196, 38);
            this.txt_Password.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Name.Location = new System.Drawing.Point(166, 9);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(196, 38);
            this.txt_Name.TabIndex = 6;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Password.ForeColor = System.Drawing.Color.Navy;
            this.lb_Password.Location = new System.Drawing.Point(13, 72);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(133, 43);
            this.lb_Password.TabIndex = 5;
            this.lb_Password.Text = "Password";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Name.ForeColor = System.Drawing.Color.Navy;
            this.lb_Name.Location = new System.Drawing.Point(13, 9);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(88, 43);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Name";
            // 
            // btn_Cencel
            // 
            this.btn_Cencel.BackColor = System.Drawing.Color.Navy;
            this.btn_Cencel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cencel.ForeColor = System.Drawing.Color.Orange;
            this.btn_Cencel.Location = new System.Drawing.Point(21, 129);
            this.btn_Cencel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cencel.Name = "btn_Cencel";
            this.btn_Cencel.Size = new System.Drawing.Size(125, 46);
            this.btn_Cencel.TabIndex = 11;
            this.btn_Cencel.Text = "Cencel";
            this.btn_Cencel.UseVisualStyleBackColor = false;
            this.btn_Cencel.Click += new System.EventHandler(this.btn_Cencel_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Navy;
            this.btn_Register.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Register.ForeColor = System.Drawing.Color.Orange;
            this.btn_Register.Location = new System.Drawing.Point(234, 129);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(125, 46);
            this.btn_Register.TabIndex = 10;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(376, 188);
            this.Controls.Add(this.btn_Cencel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Name);
            this.MaximumSize = new System.Drawing.Size(394, 235);
            this.MinimumSize = new System.Drawing.Size(394, 235);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Cencel;
        private System.Windows.Forms.Button btn_Register;
    }
}