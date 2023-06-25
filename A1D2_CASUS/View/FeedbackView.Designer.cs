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
            DGVFeedback = new DataGridView();
            FBCBXSupervisor = new ComboBox();
            FBRTBNotes = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            FBTBBonuspoints = new TrackBar();
            BTNDelete = new Button();
            BTNUpdate = new Button();
            BTNCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FBDTPCreatedate = new DateTimePicker();
            FBCBCompleted = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            FBRTBContents = new RichTextBox();
            label9 = new Label();
            label10 = new Label();
            FBCBXStudent = new ComboBox();
            FBCBXAssignment = new ComboBox();
            FBCBXReviewer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGVFeedback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FBTBBonuspoints).BeginInit();
            SuspendLayout();
            // 
            // DGVFeedback
            // 
            DGVFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFeedback.Location = new Point(2, 0);
            DGVFeedback.Margin = new Padding(3, 2, 3, 2);
            DGVFeedback.MultiSelect = false;
            DGVFeedback.Name = "DGVFeedback";
            DGVFeedback.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGVFeedback.RowTemplate.Height = 29;
            DGVFeedback.Size = new Size(927, 278);
            DGVFeedback.TabIndex = 1;
            DGVFeedback.CellContentClick += DGVFeedback_CellContentClick;
            // 
            // FBCBXSupervisor
            // 
            FBCBXSupervisor.DisplayMember = "Name";
            FBCBXSupervisor.FormattingEnabled = true;
            FBCBXSupervisor.Location = new Point(502, 322);
            FBCBXSupervisor.Name = "FBCBXSupervisor";
            FBCBXSupervisor.Size = new Size(186, 23);
            FBCBXSupervisor.TabIndex = 2;
            FBCBXSupervisor.ValueMember = "Id";
            FBCBXSupervisor.SelectedIndexChanged += FBCBXSupervisor_SelectedIndexChanged;
            // 
            // FBRTBNotes
            // 
            FBRTBNotes.Location = new Point(73, 365);
            FBRTBNotes.Name = "FBRTBNotes";
            FBRTBNotes.Size = new Size(246, 47);
            FBRTBNotes.TabIndex = 3;
            FBRTBNotes.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(875, 317);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 15;
            label5.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(754, 317);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 14;
            label4.Text = "0";
            // 
            // FBTBBonuspoints
            // 
            FBTBBonuspoints.Location = new Point(763, 303);
            FBTBBonuspoints.Margin = new Padding(3, 2, 3, 2);
            FBTBBonuspoints.Name = "FBTBBonuspoints";
            FBTBBonuspoints.Size = new Size(114, 45);
            FBTBBonuspoints.TabIndex = 13;
            // 
            // BTNDelete
            // 
            BTNDelete.Location = new Point(714, 388);
            BTNDelete.Margin = new Padding(3, 2, 3, 2);
            BTNDelete.Name = "BTNDelete";
            BTNDelete.Size = new Size(197, 22);
            BTNDelete.TabIndex = 18;
            BTNDelete.Text = "Remove assignment";
            BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            BTNUpdate.Location = new Point(811, 344);
            BTNUpdate.Margin = new Padding(3, 2, 3, 2);
            BTNUpdate.Name = "BTNUpdate";
            BTNUpdate.Size = new Size(100, 39);
            BTNUpdate.TabIndex = 17;
            BTNUpdate.Text = "Edit assignment";
            BTNUpdate.UseVisualStyleBackColor = true;
            // 
            // BTNCreate
            // 
            BTNCreate.Location = new Point(714, 344);
            BTNCreate.Margin = new Padding(3, 2, 3, 2);
            BTNCreate.Name = "BTNCreate";
            BTNCreate.Size = new Size(100, 39);
            BTNCreate.TabIndex = 16;
            BTNCreate.Text = "Create Feedback";
            BTNCreate.UseVisualStyleBackColor = true;
            BTNCreate.Click += BTNCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 289);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 19;
            label1.Text = "Created at";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 381);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 20;
            label2.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(763, 286);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 21;
            label3.Text = "(IF)Bonus effort points ";
            // 
            // FBDTPCreatedate
            // 
            FBDTPCreatedate.CustomFormat = "dd-MM-yyyy";
            FBDTPCreatedate.Format = DateTimePickerFormat.Custom;
            FBDTPCreatedate.Location = new Point(79, 289);
            FBDTPCreatedate.Margin = new Padding(3, 2, 3, 2);
            FBDTPCreatedate.Name = "FBDTPCreatedate";
            FBDTPCreatedate.Size = new Size(107, 23);
            FBDTPCreatedate.TabIndex = 23;
            FBDTPCreatedate.Value = new DateTime(2023, 6, 25, 20, 51, 35, 0);
            // 
            // FBCBCompleted
            // 
            FBCBCompleted.AutoSize = true;
            FBCBCompleted.Location = new Point(202, 289);
            FBCBCompleted.Margin = new Padding(3, 2, 3, 2);
            FBCBCompleted.Name = "FBCBCompleted";
            FBCBCompleted.RightToLeft = RightToLeft.Yes;
            FBCBCompleted.Size = new Size(94, 19);
            FBCBCompleted.TabIndex = 22;
            FBCBCompleted.Text = "is completed";
            FBCBCompleted.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 359);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 24;
            label6.Text = "Reviewer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 295);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 25;
            label7.Text = "Pick assignment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 333);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 26;
            label8.Text = "Contents";
            // 
            // FBRTBContents
            // 
            FBRTBContents.Location = new Point(73, 317);
            FBRTBContents.Name = "FBRTBContents";
            FBRTBContents.Size = new Size(246, 42);
            FBRTBContents.TabIndex = 27;
            FBRTBContents.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 325);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 28;
            label9.Text = "Supervisor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(350, 388);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 29;
            label10.Text = "Student";
            // 
            // FBCBXStudent
            // 
            FBCBXStudent.DisplayMember = "Name";
            FBCBXStudent.FormattingEnabled = true;
            FBCBXStudent.Location = new Point(502, 388);
            FBCBXStudent.Name = "FBCBXStudent";
            FBCBXStudent.Size = new Size(186, 23);
            FBCBXStudent.TabIndex = 30;
            FBCBXStudent.ValueMember = "Id";
            FBCBXStudent.SelectedIndexChanged += FBCBXStudent_SelectedIndexChanged;
            // 
            // FBCBXAssignment
            // 
            FBCBXAssignment.DisplayMember = "Name";
            FBCBXAssignment.FormattingEnabled = true;
            FBCBXAssignment.Location = new Point(462, 292);
            FBCBXAssignment.Name = "FBCBXAssignment";
            FBCBXAssignment.Size = new Size(277, 23);
            FBCBXAssignment.TabIndex = 31;
            FBCBXAssignment.ValueMember = "Assignment";
            FBCBXAssignment.SelectedIndexChanged += FBCBXAssignment_SelectedIndexChanged;
            // 
            // FBCBXReviewer
            // 
            FBCBXReviewer.DisplayMember = "Name";
            FBCBXReviewer.FormattingEnabled = true;
            FBCBXReviewer.Location = new Point(502, 359);
            FBCBXReviewer.Name = "FBCBXReviewer";
            FBCBXReviewer.Size = new Size(186, 23);
            FBCBXReviewer.TabIndex = 32;
            FBCBXReviewer.ValueMember = "Id";
            FBCBXReviewer.SelectedIndexChanged += FBCBXReviewer_SelectedIndexChanged;
            // 
            // FeedbackView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 431);
            Controls.Add(FBCBXReviewer);
            Controls.Add(FBCBXAssignment);
            Controls.Add(FBCBXStudent);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(FBRTBContents);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(FBDTPCreatedate);
            Controls.Add(FBCBCompleted);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNDelete);
            Controls.Add(BTNUpdate);
            Controls.Add(BTNCreate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(FBTBBonuspoints);
            Controls.Add(FBRTBNotes);
            Controls.Add(FBCBXSupervisor);
            Controls.Add(DGVFeedback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeedbackView";
            Text = "FeedbackView";
            Load += FeedbackView_Load;
            ((System.ComponentModel.ISupportInitialize)DGVFeedback).EndInit();
            ((System.ComponentModel.ISupportInitialize)FBTBBonuspoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVFeedback;
        private ComboBox FBCBXSupervisor;
        private RichTextBox FBRTBNotes;
        private Label label5;
        private Label label4;
        private TrackBar FBTBBonuspoints;
        private Button BTNDelete;
        private Button BTNUpdate;
        private Button BTNCreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker FBDTPCreatedate;
        private CheckBox FBCBCompleted;
        private Label label6;
        private Label label7;
        private Label label8;
        private RichTextBox FBRTBContents;
        private Label label9;
        private Label label10;
        private ComboBox FBCBXStudent;
        private ComboBox FBCBXReviewer;
        public ComboBox FBCBXAssignment;
    }
}