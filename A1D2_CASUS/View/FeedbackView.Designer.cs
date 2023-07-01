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
            LoadBtn = new Button();
            assignmentComboBox = new ComboBox();
            deadlineLbl = new Label();
            createBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            RTBNotes = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            CBXSupervisor = new ComboBox();
            CBXStudent = new ComboBox();
            RTBContents = new RichTextBox();
            DGVFBS = new DataGridView();
            LBFBS = new ListBox();
            ((System.ComponentModel.ISupportInitialize)DGVFBS).BeginInit();
            SuspendLayout();
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(862, 31);
            LoadBtn.Margin = new Padding(3, 4, 3, 4);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(122, 31);
            LoadBtn.TabIndex = 3;
            LoadBtn.Text = "Load feedback";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(801, 92);
            assignmentComboBox.Margin = new Padding(3, 4, 3, 4);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(220, 28);
            assignmentComboBox.TabIndex = 1;
            // 
            // deadlineLbl
            // 
            deadlineLbl.AutoSize = true;
            deadlineLbl.Location = new Point(906, 138);
            deadlineLbl.Name = "deadlineLbl";
            deadlineLbl.Size = new Size(105, 20);
            deadlineLbl.TabIndex = 13;
            deadlineLbl.Text = "DeadlineLabel";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(862, 509);
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
            label6.Location = new Point(882, 365);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 11;
            label6.Text = "Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(862, 168);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Contents";
            // 
            // RTBNotes
            // 
            RTBNotes.Location = new Point(783, 399);
            RTBNotes.Margin = new Padding(3, 4, 3, 4);
            RTBNotes.Name = "RTBNotes";
            RTBNotes.Size = new Size(228, 93);
            RTBNotes.TabIndex = 9;
            RTBNotes.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(789, 138);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Deadline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(789, 310);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(780, 277);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Supervisor";
            // 
            // CBXSupervisor
            // 
            CBXSupervisor.FormattingEnabled = true;
            CBXSupervisor.Location = new Point(871, 274);
            CBXSupervisor.Margin = new Padding(3, 4, 3, 4);
            CBXSupervisor.Name = "CBXSupervisor";
            CBXSupervisor.Size = new Size(158, 28);
            CBXSupervisor.TabIndex = 18;
            // 
            // CBXStudent
            // 
            CBXStudent.FormattingEnabled = true;
            CBXStudent.Location = new Point(871, 307);
            CBXStudent.Margin = new Padding(3, 4, 3, 4);
            CBXStudent.Name = "CBXStudent";
            CBXStudent.Size = new Size(158, 28);
            CBXStudent.TabIndex = 19;
            // 
            // RTBContents
            // 
            RTBContents.Location = new Point(789, 202);
            RTBContents.Margin = new Padding(3, 4, 3, 4);
            RTBContents.Name = "RTBContents";
            RTBContents.Size = new Size(241, 54);
            RTBContents.TabIndex = 20;
            RTBContents.Text = "";
            // 
            // DGVFBS
            // 
            DGVFBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFBS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVFBS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFBS.Location = new Point(4, -3);
            DGVFBS.MultiSelect = false;
            DGVFBS.Name = "DGVFBS";
            DGVFBS.RowHeadersWidth = 51;
            DGVFBS.RowTemplate.Height = 29;
            DGVFBS.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DGVFBS.Size = new Size(770, 305);
            DGVFBS.TabIndex = 22;
            DGVFBS.CellContentClick += DGVFBS_CellContentClick;
            // 
            // LBFBS
            // 
            LBFBS.FormattingEnabled = true;
            LBFBS.ItemHeight = 20;
            LBFBS.Location = new Point(502, 334);
            LBFBS.Name = "LBFBS";
            LBFBS.Size = new Size(150, 184);
            LBFBS.TabIndex = 23;
            // 
            // FeedbackView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(LBFBS);
            Controls.Add(DGVFBS);
            Controls.Add(RTBContents);
            Controls.Add(CBXStudent);
            Controls.Add(CBXSupervisor);
            Controls.Add(createBtn);
            Controls.Add(label6);
            Controls.Add(LoadBtn);
            Controls.Add(RTBNotes);
            Controls.Add(assignmentComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(deadlineLbl);
            Controls.Add(label5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FeedbackView";
            Text = "FeedbackView";
            ((System.ComponentModel.ISupportInitialize)DGVFBS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label4;
        private Label deadlineLbl;
        private Button createBtn;
        private Label label6;
        private Label label5;
        private RichTextBox RTBNotes;
        private ComboBox assignmentComboBox;
        private Button LoadBtn;
        private ComboBox CBXSupervisor;
        private ComboBox CBXStudent;
        private RichTextBox RTBContents;
        public DataGridView DGVFBS;
        public ListBox LBFBS;
    }
}