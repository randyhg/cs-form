namespace La_Familia_Form
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
            this.button_GoToLogin = new System.Windows.Forms.Button();
            this.button_GoToRegister = new System.Windows.Forms.Button();
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_button = new System.Windows.Forms.Button();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_panel = new System.Windows.Forms.Panel();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            this.register_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_GoToLogin
            // 
            this.button_GoToLogin.BackColor = System.Drawing.Color.DarkGray;
            this.button_GoToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_GoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoToLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_GoToLogin.Location = new System.Drawing.Point(2, 3);
            this.button_GoToLogin.Name = "button_GoToLogin";
            this.button_GoToLogin.Size = new System.Drawing.Size(274, 95);
            this.button_GoToLogin.TabIndex = 0;
            this.button_GoToLogin.Text = "Login";
            this.button_GoToLogin.UseVisualStyleBackColor = false;
            this.button_GoToLogin.Click += new System.EventHandler(this.button_GoToLogin_Click);
            // 
            // button_GoToRegister
            // 
            this.button_GoToRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_GoToRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_GoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoToRegister.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_GoToRegister.Location = new System.Drawing.Point(278, 3);
            this.button_GoToRegister.Name = "button_GoToRegister";
            this.button_GoToRegister.Size = new System.Drawing.Size(274, 95);
            this.button_GoToRegister.TabIndex = 1;
            this.button_GoToRegister.Text = "Register";
            this.button_GoToRegister.UseVisualStyleBackColor = false;
            this.button_GoToRegister.Click += new System.EventHandler(this.button_GoToRegister_Click);
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.login_button);
            this.login_panel.Controls.Add(this.login_password);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.login_username);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Location = new System.Drawing.Point(2, 104);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(550, 439);
            this.login_panel.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_button.Location = new System.Drawing.Point(102, 286);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(337, 48);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(199, 198);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(240, 20);
            this.login_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(101, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(199, 134);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(240, 20);
            this.login_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(99, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // register_panel
            // 
            this.register_panel.Controls.Add(this.labelConfirmPassword);
            this.register_panel.Controls.Add(this.confirm_password);
            this.register_panel.Controls.Add(this.label7);
            this.register_panel.Controls.Add(this.register_password);
            this.register_panel.Controls.Add(this.label5);
            this.register_panel.Controls.Add(this.register_username);
            this.register_panel.Controls.Add(this.label6);
            this.register_panel.Controls.Add(this.button_register);
            this.register_panel.Controls.Add(this.last_name);
            this.register_panel.Controls.Add(this.label3);
            this.register_panel.Controls.Add(this.first_name);
            this.register_panel.Controls.Add(this.label4);
            this.register_panel.Location = new System.Drawing.Point(5, 101);
            this.register_panel.Name = "register_panel";
            this.register_panel.Size = new System.Drawing.Size(550, 439);
            this.register_panel.TabIndex = 5;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConfirmPassword.Location = new System.Drawing.Point(202, 326);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(0, 13);
            this.labelConfirmPassword.TabIndex = 11;
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(199, 297);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '*';
            this.confirm_password.Size = new System.Drawing.Size(240, 20);
            this.confirm_password.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(101, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm";
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(199, 232);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(240, 20);
            this.register_password.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(101, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // register_username
            // 
            this.register_username.Location = new System.Drawing.Point(199, 168);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(240, 20);
            this.register_username.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(99, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username";
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_register.Location = new System.Drawing.Point(102, 372);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(337, 51);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(199, 101);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(240, 20);
            this.last_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(101, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(199, 37);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(240, 20);
            this.first_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(99, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(555, 562);
            this.Controls.Add(this.button_GoToRegister);
            this.Controls.Add(this.button_GoToLogin);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.register_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.register_panel.ResumeLayout(false);
            this.register_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_GoToLogin;
        private System.Windows.Forms.Button button_GoToRegister;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel register_panel;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConfirmPassword;
    }
}

