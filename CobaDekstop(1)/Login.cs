using MySql.Data.MySqlClient;


namespace CobaDekstop_1_
{
    public partial class Login : Form
    {
        string statment;
        int userId;
        public Login()
        {
            InitializeComponent();
            
            statment = @"select ID, Username, Password from user where Username = @Username"; // Sertakan Id di dalam kueri
        }

        public void login_onclick(object sender, EventArgs e)
        {
            string koneksiString = @"server = localhost;user id = root;database= quizinaja";
            
            using (var koneksi = new MySqlConnection(koneksiString))
            {
                try
                {
                    koneksi.Open();

                    
                    var command = new MySqlCommand(statment, koneksi);
                    string uservalue = usernm.Text;
                    command.Parameters.AddWithValue(@"Username", uservalue);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string passStored = reader.GetString("Password");
                            string passEntered = pass.Text;
                            userId = reader.GetInt32("ID");
                            if (passEntered == passStored)
                            {
                                Main();
                            }
                            else
                            {
                                MessageBox.Show("Password Salah");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Username Salah");
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi Gagal " + ex.Message);
                }


            }

        }
        public void Main()
        {
            this.Hide();
            Main_form main = new Main_form(userId);
            main.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Create_Acount createAcount = new Create_Acount();
            createAcount.ShowDialog();
            this.Close();
        }
    }
}