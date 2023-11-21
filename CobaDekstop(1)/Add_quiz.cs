using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaDekstop_1_
{
    public partial class Add_quiz : Form
    {
        string correctAnsw = "";
        int newId;
        public int UserId { get; set; }

        public Add_quiz(int UserID)
        {
            InitializeComponent();
            UserId = UserID;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addquestion(object sender, EventArgs e)
        {
            string questionString = Question.Text;
            string option_A = answer_A.Text;
            string option_B = answer_B.Text;
            string option_C = answer_C.Text;
            string option_D = answer_D.Text;
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                correctAnsw = option_A;
            }
            else if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                correctAnsw = option_B;
            }
            else if (radioButton3.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;
                correctAnsw = option_C;
            }
            else if (radioButton4.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton2.Checked = false;
                correctAnsw = option_D;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

            dgvQuestion.Rows.Add("", questionString, option_A, option_B, option_C, option_D, correctAnsw);
            clearQuestion();


        }
        private void clearQuestion()
        {
            answer_A.Text = "";
            answer_B.Text = "";
            answer_C.Text = "";
            answer_D.Text = "";
            Question.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void clearQuiz()
        {
            QuizName.Text = "";
            code.Text = "";
            description.Text = "";
            answer_A.Text = "";
            answer_B.Text = "";
            answer_C.Text = "";
            answer_D.Text = "";
            Question.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void dgvQuestion_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvQuestion.Rows[e.RowIndex].Cells["Number"].Value = (e.RowIndex + 1).ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string koneksiString = @"server=localhost;user id=root;database=quizinaja";
            using (var koneksi = new MySqlConnection(koneksiString))
            {
                try
                {
                    koneksi.Open();
                    string query1 = @"INSERT INTO `quiz` (`ID`, `UserID`, `Name`, `Code`, `Description`, `CreatedAt`) VALUES (NULL,@userId,@Name,@Code,@Desc,@CreatedAt)";

                    string query2 = @"INSERT INTO `question` (`ID`, `QuizID`, `Question`, `OptionA`, `OptionB`, `OptionC`, `OptionD`, `CorrectAnswer`) VALUES (NULL, @QuizId,@Question, @OptA , @OptB , @OptC , @OptD , @CorrectAns )";
                    using (var cmd = new MySqlCommand(query1, koneksi))
                    {
                        cmd.Parameters.AddWithValue("@userId",UserId.ToString());
                        cmd.Parameters.AddWithValue("@Name", QuizName.Text);
                        cmd.Parameters.AddWithValue("@Code", code.Text);
                        cmd.Parameters.AddWithValue("@Desc", description.Text);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);



                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        newId = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Quiz telah tersimpan");

                        
                    }
                    using (var cmd2 = new MySqlCommand(query2, koneksi))
                    {
                        for (int i = 0; i < dgvQuestion.Rows.Count ; i++)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("@QuizId", newId);
                            cmd2.Parameters.AddWithValue("@Question", dgvQuestion.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("@OptA", dgvQuestion.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("@OptB", dgvQuestion.Rows[i].Cells[3].Value.ToString());
                            cmd2.Parameters.AddWithValue("@OptC", dgvQuestion.Rows[i].Cells[4].Value.ToString());
                            cmd2.Parameters.AddWithValue("@OptD", dgvQuestion.Rows[i].Cells[5].Value.ToString());
                            cmd2.Parameters.AddWithValue("@CorrectAns", dgvQuestion.Rows[i].Cells[6].Value.ToString());
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error : "+ex.Message);
                }
                

            }
        }
    }
}
