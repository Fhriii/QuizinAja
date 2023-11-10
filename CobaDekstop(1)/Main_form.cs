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
        int QuizId;
        public int UserId { get; set; }
        public Main_form(int userId)
        {
            InitializeComponent();
            UserId = userId;
            QuizId = UserId;
        }

        private void load(object sender, EventArgs e)
        {

            string koneksiString = "server=localhost;user id=root;database=quizinaja";
            using (var koneksi = new MySqlConnection(koneksiString))
            {
                koneksi.Open();
                string query = "select Fullname from user where ID=@Userid";
                string queryQuiz = "select quiz.Name,quiz.Code,quiz.Description, COUNT(question.ID) as jumlahpertanyaan from quiz inner join question on quiz.ID = question.QuizID where quiz.UserID=@Userid  GROUP BY quiz.ID;";

                using (var cmd = new MySqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Userid", UserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullname = reader["Fullname"].ToString();
                            label1.Text = fullname;
                        }
                    }
                }

                using (var cmdQuiz = new MySqlCommand(queryQuiz, koneksi))
                {
                    cmdQuiz.Parameters.AddWithValue("@Userid", UserId);
                    cmdQuiz.Parameters.AddWithValue("@Quizid", QuizId);

                    try
                    {
                        using (var reader = cmdQuiz.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString("Name");
                                string code = reader.GetString("Code");
                                string description = reader.GetString("Description");
                                int numberOfQuestions = reader.GetInt32("jumlahpertanyaan");
                                // Pastikan Anda sudah memiliki sebuah kolom DataGridViewButtonColumn
                                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                                deleteButtonColumn.HeaderText = "Delete";
                                deleteButtonColumn.Text = "Delete";
                                deleteButtonColumn.UseColumnTextForButtonValue = true;

                                // Tambahkan kolom ke DataGridView
                                dgvQuiz.Columns.Add(deleteButtonColumn);

                                dgvQuiz.Rows.Add(name, code, description, numberOfQuestions);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }




        }

        private void AddQuiz_Click(object sender, EventArgs e)
        {
            Addquiz();
        }
        public void Addquiz()
        {
            this.Hide();
            Add_quiz add = new Add_quiz();
            add.ShowDialog();
            this.Close();
        }

        private void ViewReport_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin melanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void CellContent_Click(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
