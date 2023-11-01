namespace CobaDekstop_1_
{
    partial class Create_Acount
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
            button1 = new Button();
            birth = new DateTimePicker();
            username = new TextBox();
            fullname = new TextBox();
            pass = new TextBox();
            repass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 342);
            button1.Name = "button1";
            button1.Size = new Size(198, 36);
            button1.TabIndex = 0;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Create_Click;
            // 
            // birth
            // 
            birth.Location = new Point(84, 287);
            birth.Name = "birth";
            birth.Size = new Size(226, 23);
            birth.TabIndex = 1;
            // 
            // username
            // 
            username.Location = new Point(84, 146);
            username.Name = "username";
            username.Size = new Size(174, 23);
            username.TabIndex = 2;
            // 
            // fullname
            // 
            fullname.Location = new Point(84, 207);
            fullname.Name = "fullname";
            fullname.Size = new Size(174, 23);
            fullname.TabIndex = 3;
            // 
            // pass
            // 
            pass.Location = new Point(308, 146);
            pass.Name = "pass";
            pass.Size = new Size(158, 23);
            pass.TabIndex = 4;
            // 
            // repass
            // 
            repass.Location = new Point(308, 207);
            repass.Name = "repass";
            repass.Size = new Size(158, 23);
            repass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 128);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 189);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 269);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 128);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 189);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Retype Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(75, 30);
            label6.Name = "label6";
            label6.Size = new Size(251, 46);
            label6.TabIndex = 12;
            label6.Text = "Create Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 76);
            label7.Name = "label7";
            label7.Size = new Size(293, 15);
            label7.TabIndex = 13;
            label7.Text = "Fill in below information to complete your registration";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(233, 397);
            label8.Name = "label8";
            label8.Size = new Size(145, 15);
            label8.TabIndex = 14;
            label8.Text = "Already have an account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(384, 397);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += Login_link;
            // 
            // Create_Acount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(repass);
            Controls.Add(pass);
            Controls.Add(fullname);
            Controls.Add(username);
            Controls.Add(birth);
            Controls.Add(button1);
            Name = "Create_Acount";
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker birth;
        private TextBox username;
        private TextBox fullname;
        private TextBox pass;
        private TextBox repass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}