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
            LoadBtn = new Button();
            contentLbl = new Label();
            label7 = new Label();
            studentLbl = new Label();
            assignmentComboBox = new ComboBox();
            assignmentLbl = new Label();
            supervisorLbl = new Label();
            deadlineLbl = new Label();
            createBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            feedBackDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feedBackDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(LoadBtn);
            panel1.Controls.Add(contentLbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(studentLbl);
            panel1.Controls.Add(assignmentComboBox);
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
            panel1.Location = new Point(2, 352);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 219);
            panel1.TabIndex = 0;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(11, 131);
            LoadBtn.Margin = new Padding(3, 4, 3, 4);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(122, 31);
            LoadBtn.TabIndex = 3;
            LoadBtn.Text = "Load feedback";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.Location = new Point(301, 73);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(50, 20);
            contentLbl.TabIndex = 17;
            contentLbl.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 41);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 2;
            label7.Text = "Select assignment";
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Location = new Point(577, 131);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(50, 20);
            studentLbl.TabIndex = 16;
            studentLbl.Text = "label7";
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(11, 69);
            assignmentComboBox.Margin = new Padding(3, 4, 3, 4);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(143, 28);
            assignmentComboBox.TabIndex = 1;
            assignmentComboBox.SelectedIndexChanged += assignmentComboBox_SelectedIndexChanged;
            // 
            // assignmentLbl
            // 
            assignmentLbl.AutoSize = true;
            assignmentLbl.Location = new Point(577, 73);
            assignmentLbl.Name = "assignmentLbl";
            assignmentLbl.Size = new Size(50, 20);
            assignmentLbl.TabIndex = 15;
            assignmentLbl.Text = "label7";
            // 
            // supervisorLbl
            // 
            supervisorLbl.AutoSize = true;
            supervisorLbl.Location = new Point(577, 21);
            supervisorLbl.Name = "supervisorLbl";
            supervisorLbl.Size = new Size(17, 20);
            supervisorLbl.TabIndex = 14;
            supervisorLbl.Text = "a";
            // 
            // deadlineLbl
            // 
            deadlineLbl.AutoSize = true;
            deadlineLbl.Location = new Point(301, 21);
            deadlineLbl.Name = "deadlineLbl";
            deadlineLbl.Size = new Size(105, 20);
            deadlineLbl.TabIndex = 13;
            deadlineLbl.Text = "DeadlineLabel";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(837, 176);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(86, 31);
            createBtn.TabIndex = 12;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(854, 49);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 11;
            label6.Text = "Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 77);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Contents";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(765, 73);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(228, 93);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 21);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Deadline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 131);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 73);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Assignment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Supervisor";
            // 
            // feedBackDataGridView
            // 
            feedBackDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            feedBackDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            feedBackDataGridView.Location = new Point(3, 16);
            feedBackDataGridView.Margin = new Padding(3, 4, 3, 4);
            feedBackDataGridView.Name = "feedBackDataGridView";
            feedBackDataGridView.RowHeadersWidth = 51;
            feedBackDataGridView.RowTemplate.Height = 25;
            feedBackDataGridView.Size = new Size(1045, 316);
            feedBackDataGridView.TabIndex = 1;
            // 
            // FeedbackView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(feedBackDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FeedbackView";
            Text = "FeedbackView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)feedBackDataGridView).EndInit();
            ResumeLayout(false);
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
        private DataGridView feedBackDataGridView;
    }
}