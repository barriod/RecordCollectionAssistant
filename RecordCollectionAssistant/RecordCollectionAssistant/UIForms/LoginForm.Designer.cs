namespace RecordCollectionAssistant.UIForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.username_lbl = new System.Windows.Forms.Label();
            this.programTitle_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.createAccount_btn = new System.Windows.Forms.Button();
            this.invalidcredentials_lbl = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.username_lbl.Location = new System.Drawing.Point(35, 256);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(111, 30);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            // 
            // programTitle_lbl
            // 
            this.programTitle_lbl.AutoSize = true;
            this.programTitle_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTitle_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.programTitle_lbl.Location = new System.Drawing.Point(44, 3);
            this.programTitle_lbl.Name = "programTitle_lbl";
            this.programTitle_lbl.Size = new System.Drawing.Size(264, 30);
            this.programTitle_lbl.TabIndex = 1;
            this.programTitle_lbl.Text = "Record Collection Assistant";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.password_lbl.Location = new System.Drawing.Point(35, 286);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(104, 30);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "Password:";
            // 
            // username_txtBox
            // 
            this.username_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.username_txtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.username_txtBox.Location = new System.Drawing.Point(152, 260);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(147, 29);
            this.username_txtBox.TabIndex = 3;
            // 
            // password_txtBox
            // 
            this.password_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.password_txtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.password_txtBox.Location = new System.Drawing.Point(152, 290);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.PasswordChar = '*';
            this.password_txtBox.Size = new System.Drawing.Size(147, 29);
            this.password_txtBox.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login_btn.FlatAppearance.BorderSize = 2;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.login_btn.ForeColor = System.Drawing.Color.Transparent;
            this.login_btn.Location = new System.Drawing.Point(184, 335);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(94, 40);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createAccount_btn.FlatAppearance.BorderSize = 2;
            this.createAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount_btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createAccount_btn.ForeColor = System.Drawing.Color.Transparent;
            this.createAccount_btn.Location = new System.Drawing.Point(63, 335);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(100, 40);
            this.createAccount_btn.TabIndex = 6;
            this.createAccount_btn.Text = "Register";
            this.createAccount_btn.UseVisualStyleBackColor = true;
            this.createAccount_btn.Click += new System.EventHandler(this.createAccount_btn_Click);
            // 
            // invalidcredentials_lbl
            // 
            this.invalidcredentials_lbl.AutoSize = true;
            this.invalidcredentials_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidcredentials_lbl.ForeColor = System.Drawing.Color.Red;
            this.invalidcredentials_lbl.Location = new System.Drawing.Point(154, 237);
            this.invalidcredentials_lbl.Name = "invalidcredentials_lbl";
            this.invalidcredentials_lbl.Size = new System.Drawing.Size(0, 21);
            this.invalidcredentials_lbl.TabIndex = 7;
            // 
            // logo
            // 
            this.logo.Image = global::RecordCollectionAssistant.Properties.Resources.RCA_logo_Finished_JPG;
            this.logo.Location = new System.Drawing.Point(75, 36);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(202, 199);
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(351, 387);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.invalidcredentials_lbl);
            this.Controls.Add(this.createAccount_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.programTitle_lbl);
            this.Controls.Add(this.username_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Record Collection Assistant";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label programTitle_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button createAccount_btn;
        private System.Windows.Forms.Label invalidcredentials_lbl;
        private System.Windows.Forms.PictureBox logo;
    }
}