using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace La_Familia_Form
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=GB23-PC\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button_GoToLogin;
        }
        Color select_color = Color.FromArgb(64, 64, 64);

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            login_panel.BringToFront();
            button_GoToLogin.BackColor = Color.DarkGray;
            button_GoToRegister.BackColor = select_color;
        }

        private void button_GoToRegister_Click(object sender, EventArgs e)
        {
            register_panel.BringToFront();
            button_GoToRegister.BackColor = Color.DarkGray;
            button_GoToLogin.BackColor = select_color;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            byte[] passwordHash = System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(login_password.Text));
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [register] WHERE username=@Username AND password=@Password", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", passwordHash);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("Login successful!");
                login_username.Text = "";
                login_password.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(first_name.Text) || string.IsNullOrEmpty(last_name.Text) || string.IsNullOrEmpty(register_password.Text) || string.IsNullOrEmpty(confirm_password.Text))
            {
                MessageBox.Show("Isi dulu kocak!");
                return;
            }
            byte[] passwordHash = System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(register_password.Text));
            
            if (register_password.Text != confirm_password.Text)
            {
                labelConfirmPassword.Text = "*salah woi!";
            }
            else
            {
                labelConfirmPassword.Text = "";

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [register] (first_name, last_name, username, password) values (@First_name, @Last_name, @Username, @Password)";
                cmd.Parameters.AddWithValue("@First_name", first_name.Text);
                cmd.Parameters.AddWithValue("@Last_name", last_name.Text);
                cmd.Parameters.AddWithValue("@Username", register_username.Text);
                cmd.Parameters.AddWithValue("@Password", passwordHash);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Success!");
                first_name.Text = "";
                last_name.Text = "";
                register_username.Text = "";
                register_password.Text = "";
                confirm_password.Text = "";
            }
        }
    }
}
