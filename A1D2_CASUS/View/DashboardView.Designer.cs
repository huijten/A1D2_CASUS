namespace A1D2_CASUS.View
{
    partial class DashboardView
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
            DGVFeed = new DataGridView();
            DBCBXReviewer = new ComboBox();
            DBCBXStudent = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            DBCBXSupervisor = new ComboBox();
            DBRTBContents = new RichTextBox();
            label8 = new Label();
            DBLBAssignments = new ListBox();
            DBDTPCreatedate = new DateTimePicker();
            label1 = new Label();
            BTNDelete = new Button();
            BTNUpdate = new Button();
            BTNCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVFeed).BeginInit();
            SuspendLayout();
            // 
            // DGVFeed
            // 
            DGVFeed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DGVFeed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFeed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVFeed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFeed.Location = new Point(-2, 0);
            DGVFeed.MultiSelect = false;
            DGVFeed.Name = "DGVFeed";
            DGVFeed.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGVFeed.RowTemplate.Height = 29;
            DGVFeed.Size = new Size(1063, 412);
            DGVFeed.TabIndex = 35;
            // 
            // DBCBXReviewer
            // 
            DBCBXReviewer.DisplayMember = "Name";
            DBCBXReviewer.FormattingEnabled = true;
            DBCBXReviewer.Location = new Point(119, 521);
            DBCBXReviewer.Margin = new Padding(3, 4, 3, 4);
            DBCBXReviewer.Name = "DBCBXReviewer";
            DBCBXReviewer.Size = new Size(212, 28);
            DBCBXReviewer.TabIndex = 45;
            DBCBXReviewer.ValueMember = "Id";
            // 
            // DBCBXStudent
            // 
            DBCBXStudent.DisplayMember = "Name";
            DBCBXStudent.FormattingEnabled = true;
            DBCBXStudent.Location = new Point(119, 435);
            DBCBXStudent.Margin = new Padding(3, 4, 3, 4);
            DBCBXStudent.Name = "DBCBXStudent";
            DBCBXStudent.Size = new Size(212, 28);
            DBCBXStudent.TabIndex = 43;
            DBCBXStudent.ValueMember = "Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 437);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 42;
            label10.Text = "Student";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 480);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 41;
            label9.Text = "Supervisor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(789, 413);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 40;
            label7.Text = "Pick assignment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 521);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 39;
            label6.Text = "Reviewer";
            // 
            // DBCBXSupervisor
            // 
            DBCBXSupervisor.DisplayMember = "Name";
            DBCBXSupervisor.FormattingEnabled = true;
            DBCBXSupervisor.Location = new Point(119, 477);
            DBCBXSupervisor.Margin = new Padding(3, 4, 3, 4);
            DBCBXSupervisor.Name = "DBCBXSupervisor";
            DBCBXSupervisor.Size = new Size(212, 28);
            DBCBXSupervisor.TabIndex = 36;
            DBCBXSupervisor.ValueMember = "Id";
            // 
            // DBRTBContents
            // 
            DBRTBContents.Location = new Point(379, 437);
            DBRTBContents.Margin = new Padding(3, 4, 3, 4);
            DBRTBContents.Name = "DBRTBContents";
            DBRTBContents.Size = new Size(281, 55);
            DBRTBContents.TabIndex = 47;
            DBRTBContents.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(485, 415);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 46;
            label8.Text = "Contents";
            // 
            // DBLBAssignments
            // 
            DBLBAssignments.DisplayMember = "Name";
            DBLBAssignments.FormattingEnabled = true;
            DBLBAssignments.ItemHeight = 20;
            DBLBAssignments.Location = new Point(687, 437);
            DBLBAssignments.Name = "DBLBAssignments";
            DBLBAssignments.Size = new Size(363, 64);
            DBLBAssignments.TabIndex = 48;
            DBLBAssignments.ValueMember = "AssignmentId ";
            // 
            // DBDTPCreatedate
            // 
            DBDTPCreatedate.CustomFormat = "dd-MM-yyyy";
            DBDTPCreatedate.Format = DateTimePickerFormat.Custom;
            DBDTPCreatedate.Location = new Point(455, 536);
            DBDTPCreatedate.Name = "DBDTPCreatedate";
            DBDTPCreatedate.Size = new Size(122, 27);
            DBDTPCreatedate.TabIndex = 50;
            DBDTPCreatedate.Value = new DateTime(2023, 6, 25, 20, 51, 35, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 536);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 49;
            label1.Text = "Created at";
            // 
            // BTNDelete
            // 
            BTNDelete.Location = new Point(914, 508);
            BTNDelete.Name = "BTNDelete";
            BTNDelete.Size = new Size(101, 56);
            BTNDelete.TabIndex = 53;
            BTNDelete.Text = "Remove assignment";
            BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            BTNUpdate.Location = new Point(776, 508);
            BTNUpdate.Name = "BTNUpdate";
            BTNUpdate.Size = new Size(114, 52);
            BTNUpdate.TabIndex = 52;
            BTNUpdate.Text = "Edit assignment";
            BTNUpdate.UseVisualStyleBackColor = true;
            // 
            // BTNCreate
            // 
            BTNCreate.Location = new Point(635, 508);
            BTNCreate.Name = "BTNCreate";
            BTNCreate.Size = new Size(114, 52);
            BTNCreate.TabIndex = 51;
            BTNCreate.Text = "Create Feedbase";
            BTNCreate.UseVisualStyleBackColor = true;
            BTNCreate.Click += BTNCreate_Click;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(BTNDelete);
            Controls.Add(BTNUpdate);
            Controls.Add(BTNCreate);
            Controls.Add(DBDTPCreatedate);
            Controls.Add(label1);
            Controls.Add(DBLBAssignments);
            Controls.Add(DBRTBContents);
            Controls.Add(label8);
            Controls.Add(DBCBXReviewer);
            Controls.Add(DBCBXStudent);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DBCBXSupervisor);
            Controls.Add(DGVFeed);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Text = "DashboardView";
            Load += DashboardView_Load;
            ((System.ComponentModel.ISupportInitialize)DGVFeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGVFeed;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private RichTextBox DBRTBContents;
        private Label label8;
        private DateTimePicker DBDTPCreatedate;
        private Label label1;
        private Button BTNDelete;
        private Button BTNUpdate;
        private Button BTNCreate;
        public ComboBox DBCBXReviewer;
        public ComboBox DBCBXStudent;
        public ComboBox DBCBXSupervisor;
        public ListBox DBLBAssignments;
    }
}