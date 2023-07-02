namespace A1D2_CASUS.View
{
    partial class FeedupView
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
            DGVFeedup = new DataGridView();
            CBXStudent = new ComboBox();
            CBXSupervisor = new ComboBox();
            TXTContent = new TextBox();
            button2 = new Button();
            button1 = new Button();
            createBtn = new Button();
            loadBtn = new Button();
            notesTxtBox = new RichTextBox();
            label1 = new Label();
            assignmentComboBox = new ComboBox();
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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ATBPriority = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)DGVFeedup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ATBPriority).BeginInit();
            SuspendLayout();
            // 
            // DGVFeedup
            // 
            DGVFeedup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFeedup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFeedup.Location = new Point(12, 13);
            DGVFeedup.Margin = new Padding(3, 4, 3, 4);
            DGVFeedup.Name = "DGVFeedup";
            DGVFeedup.RowHeadersWidth = 51;
            DGVFeedup.RowTemplate.Height = 25;
            DGVFeedup.Size = new Size(1034, 359);
            DGVFeedup.TabIndex = 5;
            // 
            // CBXStudent
            // 
            CBXStudent.DisplayMember = "Name";
            CBXStudent.FormattingEnabled = true;
            CBXStudent.Location = new Point(441, 470);
            CBXStudent.Name = "CBXStudent";
            CBXStudent.Size = new Size(151, 28);
            CBXStudent.TabIndex = 54;
            CBXStudent.ValueMember = "Id";
            // 
            // CBXSupervisor
            // 
            CBXSupervisor.DisplayMember = "Name";
            CBXSupervisor.FormattingEnabled = true;
            CBXSupervisor.Location = new Point(441, 385);
            CBXSupervisor.Name = "CBXSupervisor";
            CBXSupervisor.Size = new Size(151, 28);
            CBXSupervisor.TabIndex = 53;
            CBXSupervisor.ValueMember = "Id";
            // 
            // TXTContent
            // 
            TXTContent.Location = new Point(177, 443);
            TXTContent.Name = "TXTContent";
            TXTContent.Size = new Size(202, 27);
            TXTContent.TabIndex = 52;
            // 
            // button2
            // 
            button2.Location = new Point(929, 531);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 51;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(849, 531);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 50;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(757, 532);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(86, 31);
            createBtn.TabIndex = 49;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(42, 506);
            loadBtn.Margin = new Padding(3, 4, 3, 4);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(86, 31);
            loadBtn.TabIndex = 39;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            // 
            // notesTxtBox
            // 
            notesTxtBox.Location = new Point(776, 419);
            notesTxtBox.Margin = new Padding(3, 4, 3, 4);
            notesTxtBox.Name = "notesTxtBox";
            notesTxtBox.Size = new Size(203, 105);
            notesTxtBox.TabIndex = 48;
            notesTxtBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 422);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 35;
            label1.Text = "Select assignment";
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(15, 446);
            assignmentComboBox.Margin = new Padding(3, 4, 3, 4);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(143, 28);
            assignmentComboBox.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(837, 395);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 47;
            label7.Text = "Reflection";
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Location = new Point(474, 531);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(50, 20);
            studentLbl.TabIndex = 46;
            studentLbl.Text = "label7";
            // 
            // assignmentLbl
            // 
            assignmentLbl.AutoSize = true;
            assignmentLbl.Location = new Point(615, 478);
            assignmentLbl.Name = "assignmentLbl";
            assignmentLbl.Size = new Size(50, 20);
            assignmentLbl.TabIndex = 45;
            assignmentLbl.Text = "label7";
            // 
            // supervisorLbl
            // 
            supervisorLbl.AutoSize = true;
            supervisorLbl.Location = new Point(474, 443);
            supervisorLbl.Name = "supervisorLbl";
            supervisorLbl.Size = new Size(50, 20);
            supervisorLbl.TabIndex = 44;
            supervisorLbl.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 506);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 43;
            label6.Text = "Student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 443);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 42;
            label5.Text = "Assignment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 411);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 41;
            label4.Text = "Supervisor";
            // 
            // contentLbl
            // 
            contentLbl.AutoSize = true;
            contentLbl.Location = new Point(317, 411);
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(50, 20);
            contentLbl.TabIndex = 40;
            contentLbl.Text = "label4";
            // 
            // deadlineLbl
            // 
            deadlineLbl.AutoSize = true;
            deadlineLbl.Location = new Point(117, 385);
            deadlineLbl.Name = "deadlineLbl";
            deadlineLbl.Size = new Size(25, 20);
            deadlineLbl.TabIndex = 38;
            deadlineLbl.Text = "aa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 406);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 37;
            label3.Text = "Contents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 385);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 34;
            label2.Text = "Deadline";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 517);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 58;
            label8.Text = "10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(211, 529);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 57;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(256, 478);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 55;
            label10.Text = "Priority";
            // 
            // ATBPriority
            // 
            ATBPriority.Location = new Point(222, 507);
            ATBPriority.Maximum = 5;
            ATBPriority.Name = "ATBPriority";
            ATBPriority.Size = new Size(130, 56);
            ATBPriority.TabIndex = 56;
            // 
            // FeedupView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(ATBPriority);
            Controls.Add(CBXStudent);
            Controls.Add(CBXSupervisor);
            Controls.Add(TXTContent);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(createBtn);
            Controls.Add(loadBtn);
            Controls.Add(notesTxtBox);
            Controls.Add(label1);
            Controls.Add(assignmentComboBox);
            Controls.Add(label7);
            Controls.Add(studentLbl);
            Controls.Add(assignmentLbl);
            Controls.Add(supervisorLbl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(contentLbl);
            Controls.Add(deadlineLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DGVFeedup);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FeedupView";
            Text = "FeedupView";
            ((System.ComponentModel.ISupportInitialize)DGVFeedup).EndInit();
            ((System.ComponentModel.ISupportInitialize)ATBPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVFeedup;
        private ComboBox CBXStudent;
        private ComboBox CBXSupervisor;
        private TextBox TXTContent;
        private Button button2;
        private Button button1;
        private Button createBtn;
        private Button loadBtn;
        private RichTextBox notesTxtBox;
        private Label label1;
        private ComboBox assignmentComboBox;
        private Label label7;
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
        private Label label8;
        private Label label9;
        private Label label10;
        private TrackBar ATBPriority;
    }
}