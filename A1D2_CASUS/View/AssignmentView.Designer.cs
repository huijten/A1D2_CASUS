namespace A1D2_CASUS.View
{
    partial class AssignmentView
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
            DGVAssignment = new DataGridView();
            ATXTName = new TextBox();
            ACBCompleted = new CheckBox();
            ATBPoints = new TrackBar();
            ADTPDeadline = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BTNCreate = new Button();
            BTNUpdate = new Button();
            BTNDelete = new Button();
            label7 = new Label();
            label6 = new Label();
            CBXSupervisor = new ComboBox();
            CBXStudent = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGVAssignment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ATBPoints).BeginInit();
            SuspendLayout();
            // 
            // DGVAssignment
            // 
            DGVAssignment.AccessibleName = "DGVAssignment";
            DGVAssignment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAssignment.Dock = DockStyle.Top;
            DGVAssignment.Location = new Point(0, 0);
            DGVAssignment.MultiSelect = false;
            DGVAssignment.Name = "DGVAssignment";
            DGVAssignment.RightToLeft = RightToLeft.No;
            DGVAssignment.RowHeadersWidth = 51;
            DGVAssignment.RowTemplate.Height = 29;
            DGVAssignment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAssignment.Size = new Size(1062, 436);
            DGVAssignment.TabIndex = 1;
            // 
            // ATXTName
            // 
            ATXTName.Location = new Point(12, 489);
            ATXTName.Name = "ATXTName";
            ATXTName.Size = new Size(202, 27);
            ATXTName.TabIndex = 2;
            // 
            // ACBCompleted
            // 
            ACBCompleted.AutoSize = true;
            ACBCompleted.Location = new Point(389, 491);
            ACBCompleted.Name = "ACBCompleted";
            ACBCompleted.RightToLeft = RightToLeft.Yes;
            ACBCompleted.Size = new Size(117, 24);
            ACBCompleted.TabIndex = 4;
            ACBCompleted.Text = "is completed";
            ACBCompleted.UseVisualStyleBackColor = true;
            // 
            // ATBPoints
            // 
            ATBPoints.Location = new Point(577, 486);
            ATBPoints.Name = "ATBPoints";
            ATBPoints.Size = new Size(130, 56);
            ATBPoints.TabIndex = 10;
            // 
            // ADTPDeadline
            // 
            ADTPDeadline.CustomFormat = "dd-MM-yyyy";
            ADTPDeadline.Format = DateTimePickerFormat.Custom;
            ADTPDeadline.Location = new Point(261, 491);
            ADTPDeadline.Name = "ADTPDeadline";
            ADTPDeadline.Size = new Size(122, 27);
            ADTPDeadline.TabIndex = 6;
            ADTPDeadline.Value = new DateTime(2023, 6, 25, 20, 51, 35, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 456);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 7;
            label1.Text = "Description of the assignment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 454);
            label2.Name = "label2";
            label2.Size = new Size(246, 20);
            label2.TabIndex = 8;
            label2.Text = "When is the deadline of completion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(541, 454);
            label3.Name = "label3";
            label3.Size = new Size(201, 20);
            label3.TabIndex = 9;
            label3.Text = "Points gained for completion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(566, 508);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 11;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(704, 508);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 12;
            label5.Text = "10";
            // 
            // BTNCreate
            // 
            BTNCreate.Location = new Point(785, 458);
            BTNCreate.Name = "BTNCreate";
            BTNCreate.Size = new Size(114, 52);
            BTNCreate.TabIndex = 13;
            BTNCreate.Text = "Create new assignment";
            BTNCreate.UseVisualStyleBackColor = true;
            BTNCreate.Click += BTNCreate_Click;
            // 
            // BTNUpdate
            // 
            BTNUpdate.Location = new Point(896, 458);
            BTNUpdate.Name = "BTNUpdate";
            BTNUpdate.Size = new Size(114, 52);
            BTNUpdate.TabIndex = 14;
            BTNUpdate.Text = "Edit assignment";
            BTNUpdate.UseVisualStyleBackColor = true;
            BTNUpdate.Click += BTNUpdate_Click;
            // 
            // BTNDelete
            // 
            BTNDelete.Location = new Point(785, 518);
            BTNDelete.Name = "BTNDelete";
            BTNDelete.Size = new Size(225, 29);
            BTNDelete.TabIndex = 15;
            BTNDelete.Text = "Remove assignment";
            BTNDelete.UseVisualStyleBackColor = true;
            BTNDelete.Click += BTNDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 533);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 20;
            label7.Text = "Assigned to";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 536);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 21;
            label6.Text = "Approved by";
            // 
            // CBXSupervisor
            // 
            CBXSupervisor.DisplayMember = "Name";
            CBXSupervisor.FormattingEnabled = true;
            CBXSupervisor.Location = new Point(150, 533);
            CBXSupervisor.Name = "CBXSupervisor";
            CBXSupervisor.Size = new Size(151, 28);
            CBXSupervisor.TabIndex = 22;
            CBXSupervisor.ValueMember = "Id";
            // 
            // CBXStudent
            // 
            CBXStudent.DisplayMember = "Name";
            CBXStudent.FormattingEnabled = true;
            CBXStudent.Location = new Point(420, 533);
            CBXStudent.Name = "CBXStudent";
            CBXStudent.Size = new Size(151, 28);
            CBXStudent.TabIndex = 23;
            CBXStudent.ValueMember = "Id";
            // 
            // AssignmentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(CBXStudent);
            Controls.Add(CBXSupervisor);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(BTNDelete);
            Controls.Add(BTNUpdate);
            Controls.Add(BTNCreate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ADTPDeadline);
            Controls.Add(ATBPoints);
            Controls.Add(ACBCompleted);
            Controls.Add(ATXTName);
            Controls.Add(DGVAssignment);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AssignmentView";
            Text = "AssignmentView";
            Load += AssignmentView_Load;
            ((System.ComponentModel.ISupportInitialize)DGVAssignment).EndInit();
            ((System.ComponentModel.ISupportInitialize)ATBPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGVAssignment;
        private TextBox ATXTName;
        private CheckBox ACBCompleted;
        private TrackBar ATBPoints;
        private DateTimePicker ADTPDeadline;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BTNCreate;
        private Button BTNUpdate;
        private Button BTNDelete;
        private Label label7;
        private Label label6;
        private ComboBox CBXSupervisor;
        private ComboBox CBXStudent;
    }
}