namespace DDES_Client.Views
{
    partial class Login
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
            this.lbl_account_type = new System.Windows.Forms.Label();
            this.rad_account_parent = new System.Windows.Forms.RadioButton();
            this.rad_account_teacher = new System.Windows.Forms.RadioButton();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_account_type
            // 
            this.lbl_account_type.AutoSize = true;
            this.lbl_account_type.Location = new System.Drawing.Point(26, 20);
            this.lbl_account_type.Name = "lbl_account_type";
            this.lbl_account_type.Size = new System.Drawing.Size(79, 15);
            this.lbl_account_type.TabIndex = 0;
            this.lbl_account_type.Text = "Account Type";
            // 
            // rad_account_parent
            // 
            this.rad_account_parent.AutoSize = true;
            this.rad_account_parent.Checked = true;
            this.rad_account_parent.Location = new System.Drawing.Point(26, 38);
            this.rad_account_parent.Name = "rad_account_parent";
            this.rad_account_parent.Size = new System.Drawing.Size(59, 19);
            this.rad_account_parent.TabIndex = 1;
            this.rad_account_parent.TabStop = true;
            this.rad_account_parent.Text = "Parent";
            this.rad_account_parent.UseVisualStyleBackColor = true;
            // 
            // rad_account_teacher
            // 
            this.rad_account_teacher.AutoSize = true;
            this.rad_account_teacher.Location = new System.Drawing.Point(91, 38);
            this.rad_account_teacher.Name = "rad_account_teacher";
            this.rad_account_teacher.Size = new System.Drawing.Size(65, 19);
            this.rad_account_teacher.TabIndex = 2;
            this.rad_account_teacher.TabStop = true;
            this.rad_account_teacher.Text = "Teacher";
            this.rad_account_teacher.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(26, 88);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(130, 23);
            this.txt_username.TabIndex = 3;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(26, 70);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(60, 15);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(26, 114);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(57, 15);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(26, 132);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(130, 23);
            this.txt_password.TabIndex = 6;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(81, 161);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 29);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 206);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.rad_account_teacher);
            this.Controls.Add(this.rad_account_parent);
            this.Controls.Add(this.lbl_account_type);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_account_type;
        private RadioButton rad_account_parent;
        private RadioButton rad_account_teacher;
        private TextBox txt_username;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txt_password;
        private Button btn_login;
    }
}