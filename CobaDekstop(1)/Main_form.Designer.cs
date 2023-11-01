namespace CobaDekstop_1_
{
    partial class Main_form
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
            dgvQuiz = new DataGridView();
            QuizName = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQuiz).BeginInit();
            SuspendLayout();
            // 
            // dgvQuiz
            // 
            dgvQuiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuiz.Columns.AddRange(new DataGridViewColumn[] { QuizName, Code, Description, Number });
            dgvQuiz.Location = new Point(243, 117);
            dgvQuiz.Name = "dgvQuiz";
            dgvQuiz.RowTemplate.Height = 25;
            dgvQuiz.Size = new Size(451, 183);
            dgvQuiz.TabIndex = 0;
            // 
            // QuizName
            // 
            QuizName.HeaderText = "QuizName";
            QuizName.Name = "QuizName";
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.Name = "Code";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvQuiz);
            Name = "Main_form";
            Text = "Main_form";
            Load += load;
            ((System.ComponentModel.ISupportInitialize)dgvQuiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQuiz;
        private DataGridViewTextBoxColumn QuizName;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Number;
        private Label label1;
    }
}