namespace CobaDekstop_1_
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernm = new TextBox();
            pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // usernm
            // 
            usernm.Location = new Point(285, 134);
            usernm.Name = "usernm";
            usernm.Size = new Size(115, 23);
            usernm.TabIndex = 0;
            // 
            // pass
            // 
            pass.Location = new Point(286, 201);
            pass.Name = "pass";
            pass.Size = new Size(114, 23);
            pass.TabIndex = 1;
            pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 35);
            label1.MinimumSize = new Size(80, 40);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 2;
            label1.Text = "QuizinAja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 81);
            label2.Name = "label2";
            label2.Size = new Size(207, 15);
            label2.TabIndex = 3;
            label2.Text = "Infinite Learning , Learn Without Limit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 137);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 204);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(247, 262);
            button1.Name = "button1";
            button1.Size = new Size(213, 34);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += login_onclick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(385, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(314, 323);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Acount";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pass);
            Controls.Add(usernm);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernm;
        private TextBox pass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
    }
}