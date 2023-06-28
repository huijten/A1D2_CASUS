namespace A1D2_CASUS.View
{
    partial class FeedbackView
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            createBtn = new Button();
            deadlineLbl = new Label();
            supervisorLbl = new Label();
            assignmentLbl = new Label();
            studentLbl = new Label();
            contentLbl = new Label();
            assignmentComboBox = new ComboBox();
            label7 = new Label();
            LoadBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(contentLbl);
            panel1.Controls.Add(studentLbl);
            panel1.Controls.Add(assignmentLbl);
            panel1.Controls.Add(supervisorLbl);
            panel1.Controls.Add(deadlineLbl);
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 164);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Supervisor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 55);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Assignment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 98);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Student";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 16);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Deadline";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(669, 55);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(200, 71);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 60);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Contents";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(747, 37);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 11;
            label6.Text = "Notes";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(732, 132);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 12;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // deadlineLbl
            // 
            deadlineLbl.AutoSize = true;
            deadlineLbl.Location = new Point(104, 16);
            deadlineLbl.Name = "deadlineLbl";
            deadlineLbl.Size = new Size(81, 15);
            deadlineLbl.TabIndex = 13;
            deadlineLbl.Text = "DeadlineLabel";
            // 
            // supervisorLbl
            // 
            supervisorLbl.AutoSize = true;
            supervisorLbl.Location = new Point(505, 16);
            supervisorLbl.Name = "supervisorLbl";
            supervisorLbl.Size = new Size(13, 15);
            supervisorLbl.TabIndex = 14;
            supervisorLbl.Text = "a";
            // 
            // assignmentLbl
            // 
            assignmentLbl.AutoSize = true;
            assignmentLbl.Location = new Point(505, 55);
            assignmentLbl.Name = "assignmentLbl";
            assignmentLbl.Size = new Size(38, 15);
            assignmentLbl.TabIndex = 15;
            assignmentLbl.Text = "label7";
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Location = new Point(505, 98);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(38, 15);
            studentLbl.TabIndex = 16;
            studentLbl.Text = "label7";
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.Location = new Point(104, 60);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(38, 15);
            contentLbl.TabIndex = 17;
            contentLbl.Text = "label7";
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(265, 62);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(193, 23);
            assignmentComboBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 34);
            label7.Name = "label7";
            label7.Size = new Size(193, 15);
            label7.TabIndex = 2;
            label7.Text = "Select assignment to load feedback";
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(309, 117);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(107, 23);
            LoadBtn.TabIndex = 3;
            LoadBtn.Text = "Load feedback";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // FeedbackView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 431);
            Controls.Add(LoadBtn);
            Controls.Add(label7);
            Controls.Add(assignmentComboBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeedbackView";
            Text = "FeedbackView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label contentLbl;
        private Label studentLbl;
        private Label assignmentLbl;
        private Label supervisorLbl;
        private Label deadlineLbl;
        private Button createBtn;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBox2;
        private ComboBox assignmentComboBox;
        private Label label7;
        private Button LoadBtn;
    }
}