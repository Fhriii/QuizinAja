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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            QuizName = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvQuiz).BeginInit();
            SuspendLayout();
            // 
            // dgvQuiz
            // 
            dgvQuiz.AllowUserToAddRows = false;
            dgvQuiz.AllowUserToResizeRows = false;
            dgvQuiz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuiz.Columns.AddRange(new DataGridViewColumn[] { QuizName, Code, Description, Number });
            dgvQuiz.Location = new Point(287, 47);
            dgvQuiz.Name = "dgvQuiz";
            dgvQuiz.ReadOnly = true;
            dgvQuiz.RowHeadersVisible = false;
            dgvQuiz.RowTemplate.Height = 25;
            dgvQuiz.ShowEditingIcon = false;
            dgvQuiz.Size = new Size(501, 391);
            dgvQuiz.TabIndex = 0;
            dgvQuiz.CellContentClick += CellContent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 35);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Welcome";
            // 
            // button1
            // 
            button1.Location = new Point(72, 184);
            button1.Name = "button1";
            button1.Size = new Size(110, 30);
            button1.TabIndex = 3;
            button1.Text = "Add Quiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddQuiz_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 231);
            button2.Name = "button2";
            button2.Size = new Size(110, 31);
            button2.TabIndex = 4;
            button2.Text = "View Quiz Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ViewReport_Click;
            // 
            // button3
            // 
            button3.Location = new Point(72, 415);
            button3.Name = "button3";
            button3.Size = new Size(95, 23);
            button3.TabIndex = 5;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Logout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 29);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Your Quiz";
            // 
            // QuizName
            // 
            QuizName.HeaderText = "QuizName";
            QuizName.Name = "QuizName";
            QuizName.ReadOnly = true;
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.Name = "Code";
            Code.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
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
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private DataGridViewTextBoxColumn QuizName;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Number;
    }
}