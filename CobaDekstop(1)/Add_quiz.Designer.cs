namespace CobaDekstop_1_
{
    partial class Add_quiz
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
            QuizName = new TextBox();
            code = new TextBox();
            description = new TextBox();
            groupBox1 = new GroupBox();
            dgvQuestion = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Quest = new DataGridViewTextBoxColumn();
            OptionA = new DataGridViewTextBoxColumn();
            OptionB = new DataGridViewTextBoxColumn();
            OptionC = new DataGridViewTextBoxColumn();
            OptionD = new DataGridViewTextBoxColumn();
            CorrectAnswer = new DataGridViewTextBoxColumn();
            addquest = new Button();
            answer_D = new TextBox();
            answer_C = new TextBox();
            answer_B = new TextBox();
            answer_A = new TextBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Question = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            SuspendLayout();
            // 
            // QuizName
            // 
            QuizName.Location = new Point(96, 56);
            QuizName.Name = "QuizName";
            QuizName.Size = new Size(100, 23);
            QuizName.TabIndex = 0;
            // 
            // code
            // 
            code.Location = new Point(96, 117);
            code.Name = "code";
            code.Size = new Size(100, 23);
            code.TabIndex = 1;
            // 
            // description
            // 
            description.Location = new Point(315, 56);
            description.Multiline = true;
            description.Name = "description";
            description.ScrollBars = ScrollBars.Both;
            description.Size = new Size(411, 84);
            description.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvQuestion);
            groupBox1.Controls.Add(addquest);
            groupBox1.Controls.Add(answer_D);
            groupBox1.Controls.Add(answer_C);
            groupBox1.Controls.Add(answer_B);
            groupBox1.Controls.Add(answer_A);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(Question);
            groupBox1.Location = new Point(79, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 306);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question Data";
            // 
            // dgvQuestion
            // 
            dgvQuestion.AllowUserToAddRows = false;
            dgvQuestion.AllowUserToResizeColumns = false;
            dgvQuestion.AllowUserToResizeRows = false;
            dgvQuestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Columns.AddRange(new DataGridViewColumn[] { Number, Quest, OptionA, OptionB, OptionC, OptionD, CorrectAnswer });
            dgvQuestion.Location = new Point(23, 158);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.ReadOnly = true;
            dgvQuestion.RowHeadersVisible = false;
            dgvQuestion.RowTemplate.Height = 25;
            dgvQuestion.Size = new Size(624, 123);
            dgvQuestion.TabIndex = 10;
            dgvQuestion.CellContentClick += dataGridView1_CellContentClick;
            dgvQuestion.RowPrePaint += dgvQuestion_RowPrePaint;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Quest
            // 
            Quest.HeaderText = "Question";
            Quest.Name = "Quest";
            Quest.ReadOnly = true;
            // 
            // OptionA
            // 
            OptionA.HeaderText = "OptionA";
            OptionA.Name = "OptionA";
            OptionA.ReadOnly = true;
            // 
            // OptionB
            // 
            OptionB.HeaderText = "OptionB";
            OptionB.Name = "OptionB";
            OptionB.ReadOnly = true;
            // 
            // OptionC
            // 
            OptionC.HeaderText = "OptionC";
            OptionC.Name = "OptionC";
            OptionC.ReadOnly = true;
            // 
            // OptionD
            // 
            OptionD.HeaderText = "OptionD";
            OptionD.Name = "OptionD";
            OptionD.ReadOnly = true;
            // 
            // CorrectAnswer
            // 
            CorrectAnswer.HeaderText = "CorrectAnswer";
            CorrectAnswer.Name = "CorrectAnswer";
            CorrectAnswer.ReadOnly = true;
            // 
            // addquest
            // 
            addquest.Location = new Point(462, 85);
            addquest.Name = "addquest";
            addquest.Size = new Size(92, 23);
            addquest.TabIndex = 9;
            addquest.Text = "addQuestion";
            addquest.UseVisualStyleBackColor = true;
            addquest.Click += addquestion;
            // 
            // answer_D
            // 
            answer_D.Location = new Point(303, 127);
            answer_D.Name = "answer_D";
            answer_D.Size = new Size(100, 23);
            answer_D.TabIndex = 8;
            // 
            // answer_C
            // 
            answer_C.Location = new Point(303, 98);
            answer_C.Name = "answer_C";
            answer_C.Size = new Size(100, 23);
            answer_C.TabIndex = 7;
            // 
            // answer_B
            // 
            answer_B.Location = new Point(303, 69);
            answer_B.Name = "answer_B";
            answer_B.Size = new Size(100, 23);
            answer_B.TabIndex = 6;
            // 
            // answer_A
            // 
            answer_A.Location = new Point(303, 40);
            answer_A.Name = "answer_A";
            answer_A.Size = new Size(100, 23);
            answer_A.TabIndex = 5;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(263, 131);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(263, 102);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(263, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(263, 44);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            Question.Location = new Point(17, 40);
            Question.Multiline = true;
            Question.Name = "Question";
            Question.ScrollBars = ScrollBars.Both;
            Question.Size = new Size(192, 78);
            Question.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(566, 502);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(673, 502);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // Add_quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(description);
            Controls.Add(code);
            Controls.Add(QuizName);
            Name = "Add_quiz";
            Text = "Add_quiz";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuizName;
        private TextBox code;
        private TextBox description;
        private GroupBox groupBox1;
        private TextBox answer_D;
        private TextBox answer_C;
        private TextBox answer_B;
        private TextBox answer_A;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox Question;
        private DataGridView dgvQuestion;
        private Button addquest;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Quest;
        private DataGridViewTextBoxColumn OptionA;
        private DataGridViewTextBoxColumn OptionB;
        private DataGridViewTextBoxColumn OptionC;
        private DataGridViewTextBoxColumn OptionD;
        private DataGridViewTextBoxColumn CorrectAnswer;
    }
}