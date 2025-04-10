namespace FormFileReading
{
    partial class Login
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
            username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            password = new TextBox();
            button1 = new Button();
            newAccount = new LinkLabel();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(31, 48);
            username.Name = "username";
            username.Size = new Size(167, 27);
            username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(31, 103);
            password.Name = "password";
            password.Size = new Size(167, 27);
            password.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(31, 171);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // newAccount
            // 
            newAccount.AutoSize = true;
            newAccount.Location = new Point(31, 148);
            newAccount.Name = "newAccount";
            newAccount.Size = new Size(116, 20);
            newAccount.TabIndex = 5;
            newAccount.TabStop = true;
            newAccount.Text = "Yeni hesab yarat";
            newAccount.LinkClicked += newAccount_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 229);
            Controls.Add(newAccount);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private Label label1;
        private Label label2;
        private TextBox password;
        private Button button1;
        private LinkLabel newAccount;
    }
}