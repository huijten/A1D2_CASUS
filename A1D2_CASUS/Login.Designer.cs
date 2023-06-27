namespace A1D2_CASUS
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
            label2 = new Label();
            TXTLogin = new TextBox();
            TXTPassword = new TextBox();
            BTNLogin = new Button();
            BTNExit = new Button();
            label3 = new Label();
            label4 = new Label();
            headerLbl = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 81);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 1;
            label2.Text = "Fill in your details to continue";
            // 
            // TXTLogin
            // 
            TXTLogin.Location = new Point(231, 110);
            TXTLogin.Name = "TXTLogin";
            TXTLogin.Size = new Size(125, 27);
            TXTLogin.TabIndex = 2;
            TXTLogin.Text = "Student";
            // 
            // TXTPassword
            // 
            TXTPassword.Location = new Point(231, 166);
            TXTPassword.Name = "TXTPassword";
            TXTPassword.PasswordChar = '*';
            TXTPassword.Size = new Size(125, 27);
            TXTPassword.TabIndex = 3;
            TXTPassword.Text = "password";
            // 
            // BTNLogin
            // 
            BTNLogin.Location = new Point(185, 216);
            BTNLogin.Name = "BTNLogin";
            BTNLogin.Size = new Size(94, 29);
            BTNLogin.TabIndex = 4;
            BTNLogin.Text = "Login";
            BTNLogin.UseVisualStyleBackColor = true;
            BTNLogin.Click += BTNLogin_Click;
            // 
            // BTNExit
            // 
            BTNExit.Location = new Point(185, 264);
            BTNExit.Name = "BTNExit";
            BTNExit.Size = new Size(94, 29);
            BTNExit.TabIndex = 5;
            BTNExit.Text = "Exit";
            BTNExit.UseVisualStyleBackColor = true;
            BTNExit.Click += BTNExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 117);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 173);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.BackColor = Color.FromArgb(72, 156, 130);
            headerLbl.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            headerLbl.ForeColor = Color.White;
            headerLbl.Location = new Point(103, 9);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(271, 54);
            headerLbl.TabIndex = 8;
            headerLbl.Text = "FEEDBUF 2.0";
            // 
            // Login
            // 
            AcceptButton = BTNLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 342);
            ControlBox = false;
            Controls.Add(headerLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BTNExit);
            Controls.Add(BTNLogin);
            Controls.Add(TXTPassword);
            Controls.Add(TXTLogin);
            Controls.Add(label2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox TXTLogin;
        private TextBox TXTPassword;
        private Button BTNLogin;
        private Button BTNExit;
        private Label label3;
        private Label label4;
        private Label headerLbl;

    }
}