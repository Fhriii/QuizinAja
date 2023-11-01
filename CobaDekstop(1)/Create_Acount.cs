using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaDekstop_1_
{
    public partial class Create_Acount : Form
    {
        int userId;
        public Create_Acount()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string koneksiString = @"server = localhost;user id = root;database= quizinaja";
            using (var koneksi = new MySqlConnection(koneksiString))
            {
                try
                {
                    koneksi.Open();
                    string statment = @"insert into user (Username, FullName, DateOfBirth, Password) values(@Username,@Fullname,@Birth,@Password)";
                                if (pass.Text.Length < 4)
            {
                MessageBox.Show("Password harus terdiri dari minimal 4 karakter.");
                return; // Stop the method execution
            }

                    using (var cmd = new MySqlCommand(statment, koneksi))
                    {
                        cmd.Parameters.AddWithValue(@"Username", username.Text);
                        cmd.Parameters.AddWithValue(@"Fullname", fullname.Text);
                        cmd.Parameters.AddWithValue(@"Birth", birth.Value);
                        cmd.Parameters.AddWithValue(@"Password", pass.Text);

                        cmd.ExecuteNonQuery();

                        string pas = pass.Text;
                        string retypepass = repass.Text;
                        if (pas == retypepass)
                        {
                            main();
                        }
                        else
                        {
                            MessageBox.Show("Password tidak sama");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        public void main()
        {
            this.Hide();
            Main_form main = new Main_form(userId);
            main.ShowDialog();
            this.Close();
        }

        private void Login_link(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
