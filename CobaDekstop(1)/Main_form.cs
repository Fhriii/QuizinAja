using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CobaDekstop_1_
{
    public partial class Main_form : Form
    {

        public int UserId { get; set; }
        public Main_form(int userId)
        {
            InitializeComponent();
            UserId = userId;

        }

        private void load(object sender, EventArgs e)
        {

            string koneksiString = "server=localhost;user id=root;database=quizinaja";
            using (var koneksi = new MySqlConnection(koneksiString))
            {
                koneksi.Open();
                string query = "select Fullname from user where ID=@Userid";
                
                using (var cmd = new MySqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue(@"Userid", UserId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullname = reader["Fullname"].ToString();
                            label1.Text = "Fullname: " + fullname;
                        }
                        //while (reader.Read())
                        //{
                            
                            
                        //    string name = reader.GetString("Name");
                        //    string code = reader.GetString("Code");
                        //    string description = reader.GetString("Description");
                        //    int numberOfQuestions = reader.GetInt32("NumberOfQuestions");

                          
                        //    dgvQuiz.Rows.Add(name, code, description, numberOfQuestions, "Delete");
                        //}
                    }
                }


            }



        }
    }
}
