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
    public partial class Add_quiz : Form
    {
        string correctAnsw="";
        
        public Add_quiz()
        {
            InitializeComponent();
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
            clearAfter();


        }
        private void clearAfter()
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
        private void dgvQuestion_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvQuestion.Rows[e.RowIndex].Cells["Number"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
