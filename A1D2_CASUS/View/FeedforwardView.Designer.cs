namespace A1D2_CASUS.View
{
    partial class FeedforwardView
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
            label1 = new Label();
            assignmentComboBox = new ComboBox();
            loadBtn = new Button();
            panel1 = new Panel();
            createBtn = new Button();
            notesTxtBox = new RichTextBox();
            label7 = new Label();
            studentLbl = new Label();
            assignmentLbl = new Label();
            supervisorLbl = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            contentLbl = new Label();
            deadlineLbl = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Select assignment";
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(23, 54);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(126, 23);
            assignmentComboBox.TabIndex = 1;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(46, 99);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(75, 23);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(loadBtn);
            panel1.Controls.Add(notesTxtBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(assignmentComboBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(studentLbl);
            panel1.Controls.Add(assignmentLbl);
            panel1.Controls.Add(supervisorLbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(contentLbl);
            panel1.Controls.Add(deadlineLbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 159);
            panel1.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(727, 128);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 12;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // notesTxtBox
            // 
            notesTxtBox.Location = new Point(687, 42);
            notesTxtBox.Name = "notesTxtBox";
            notesTxtBox.Size = new Size(178, 80);
            notesTxtBox.TabIndex = 11;
            notesTxtBox.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(740, 24);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 10;
            label7.Text = "Notes";
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Location = new Point(553, 86);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(38, 15);
            studentLbl.TabIndex = 9;
            studentLbl.Text = "label7";
            // 
            // assignmentLbl
            // 
            assignmentLbl.AutoSize = true;
            assignmentLbl.Location = new Point(553, 54);
            assignmentLbl.Name = "assignmentLbl";
            assignmentLbl.Size = new Size(38, 15);
            assignmentLbl.TabIndex = 8;
            assignmentLbl.Text = "label7";
            // 
            // supervisorLbl
            // 
            supervisorLbl.AutoSize = true;
            supervisorLbl.Location = new Point(553, 24);
            supervisorLbl.Name = "supervisorLbl";
            supervisorLbl.Size = new Size(38, 15);
            supervisorLbl.TabIndex = 7;
            supervisorLbl.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 86);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 6;
            label6.Text = "Student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 54);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "Assignment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 24);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "Supervisor";
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.Location = new Point(298, 54);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(38, 15);
            contentLbl.TabIndex = 3;
            contentLbl.Text = "label4";
            // 
            // deadlineLbl
            // 
            deadlineLbl.AutoSize = true;
            deadlineLbl.Location = new Point(298, 24);
            deadlineLbl.Name = "deadlineLbl";
            deadlineLbl.Size = new Size(19, 15);
            deadlineLbl.TabIndex = 2;
            deadlineLbl.Text = "aa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 54);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "Contents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 24);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Deadline";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(905, 249);
            dataGridView1.TabIndex = 4;
            // 
            // FeedforwardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 431);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeedforwardView";
            Text = "FeedforwardView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox assignmentComboBox;
        private Button loadBtn;
        private Panel panel1;
        private Label studentLbl;
        private Label assignmentLbl;
        private Label supervisorLbl;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label contentLbl;
        private Label deadlineLbl;
        private Label label3;
        private Label label2;
        private Button createBtn;
        private RichTextBox notesTxtBox;
        private Label label7;
        private DataGridView dataGridView1;
    }
}