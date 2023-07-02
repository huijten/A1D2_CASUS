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
            button2 = new Button();
            button1 = new Button();
            CBXStudent = new ComboBox();
            CBXSupervisor = new ComboBox();
            TXTContent = new TextBox();
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
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Select assignment";
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(26, 72);
            assignmentComboBox.Margin = new Padding(3, 4, 3, 4);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(143, 28);
            assignmentComboBox.TabIndex = 1;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(53, 132);
            loadBtn.Margin = new Padding(3, 4, 3, 4);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(86, 31);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(CBXStudent);
            panel1.Controls.Add(CBXSupervisor);
            panel1.Controls.Add(TXTContent);
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
            panel1.Location = new Point(3, 356);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 212);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(948, 157);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 35;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(848, 160);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // CBXStudent
            // 
            CBXStudent.DisplayMember = "Name";
            CBXStudent.FormattingEnabled = true;
            CBXStudent.Location = new Point(450, 110);
            CBXStudent.Name = "CBXStudent";
            CBXStudent.Size = new Size(151, 28);
            CBXStudent.TabIndex = 33;
            CBXStudent.ValueMember = "Id";
            // 
            // CBXSupervisor
            // 
            CBXSupervisor.DisplayMember = "Name";
            CBXSupervisor.FormattingEnabled = true;
            CBXSupervisor.Location = new Point(450, 17);
            CBXSupervisor.Name = "CBXSupervisor";
            CBXSupervisor.Size = new Size(151, 28);
            CBXSupervisor.TabIndex = 32;
            CBXSupervisor.ValueMember = "Id";
            // 
            // TXTContent
            // 
            TXTContent.Location = new Point(188, 69);
            TXTContent.Name = "TXTContent";
            TXTContent.Size = new Size(202, 27);
            TXTContent.TabIndex = 31;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(768, 158);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(86, 31);
            createBtn.TabIndex = 12;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // notesTxtBox
            // 
            notesTxtBox.Location = new Point(787, 45);
            notesTxtBox.Margin = new Padding(3, 4, 3, 4);
            notesTxtBox.Name = "notesTxtBox";
            notesTxtBox.Size = new Size(203, 105);
            notesTxtBox.TabIndex = 11;
            notesTxtBox.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(848, 21);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 10;
            label7.Text = "Notes";
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Location = new Point(491, 172);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(50, 20);
            studentLbl.TabIndex = 9;
            studentLbl.Text = "label7";
            // 
            // assignmentLbl
            // 
            assignmentLbl.AutoSize = true;
            assignmentLbl.Location = new Point(231, 161);
            assignmentLbl.Name = "assignmentLbl";
            assignmentLbl.Size = new Size(50, 20);
            assignmentLbl.TabIndex = 8;
            assignmentLbl.Text = "label7";
            // 
            // supervisorLbl
            // 
            supervisorLbl.AutoSize = true;
            supervisorLbl.Location = new Point(491, 75);
            supervisorLbl.Name = "supervisorLbl";
            supervisorLbl.Size = new Size(50, 20);
            supervisorLbl.TabIndex = 7;
            supervisorLbl.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 143);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 6;
            label6.Text = "Student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 126);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Assignment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 48);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "Supervisor";
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.Location = new Point(328, 37);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(50, 20);
            contentLbl.TabIndex = 3;
            contentLbl.Text = "label4";
            // 
            // deadlineLbl
            // 
            deadlineLbl.AutoSize = true;
            deadlineLbl.Location = new Point(720, 80);
            deadlineLbl.Name = "deadlineLbl";
            deadlineLbl.Size = new Size(25, 20);
            deadlineLbl.TabIndex = 2;
            deadlineLbl.Text = "aa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 32);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 1;
            label3.Text = "Contents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 80);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Deadline";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1034, 344);
            dataGridView1.TabIndex = 4;
            // 
            // FeedforwardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox CBXStudent;
        private ComboBox CBXSupervisor;
        private TextBox TXTContent;
        private Button button1;
        private Button button2;
    }
}