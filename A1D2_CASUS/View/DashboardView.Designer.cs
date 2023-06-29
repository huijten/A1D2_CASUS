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
            DGVDash = new DataGridView();
            DTPCreated = new DateTimePicker();
            label2 = new Label();
            CBXSupervisor = new ComboBox();
            CBXStudent = new ComboBox();
            assignmentComboBox = new ComboBox();
            RTBContent = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BTNDelete = new Button();
            BTNUpdate = new Button();
            BTNCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVDash).BeginInit();
            SuspendLayout();
            // 
            // DGVDash
            // 
            DGVDash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDash.Location = new Point(0, 3);
            DGVDash.Name = "DGVDash";
            DGVDash.RowHeadersWidth = 51;
            DGVDash.RowTemplate.Height = 29;
            DGVDash.Size = new Size(1060, 395);
            DGVDash.TabIndex = 1;
            // 
            // DTPCreated
            // 
            DTPCreated.CustomFormat = "dd-MM-yyyy";
            DTPCreated.Format = DateTimePickerFormat.Custom;
            DTPCreated.Location = new Point(25, 520);
            DTPCreated.Name = "DTPCreated";
            DTPCreated.Size = new Size(122, 27);
            DTPCreated.TabIndex = 7;
            DTPCreated.Value = new DateTime(2023, 6, 25, 20, 51, 35, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 478);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "Date of creation";
            // 
            // CBXSupervisor
            // 
            CBXSupervisor.DisplayMember = "Id";
            CBXSupervisor.FormattingEnabled = true;
            CBXSupervisor.Location = new Point(327, 473);
            CBXSupervisor.Name = "CBXSupervisor";
            CBXSupervisor.Size = new Size(151, 28);
            CBXSupervisor.TabIndex = 10;
            CBXSupervisor.ValueMember = "Id";
            // 
            // CBXStudent
            // 
            CBXStudent.DisplayMember = "Id";
            CBXStudent.FormattingEnabled = true;
            CBXStudent.Location = new Point(327, 520);
            CBXStudent.Name = "CBXStudent";
            CBXStudent.Size = new Size(151, 28);
            CBXStudent.TabIndex = 11;
            CBXStudent.ValueMember = "Id";
            // 
            // assignmentComboBox
            // 
            assignmentComboBox.DisplayMember = "Id";
            assignmentComboBox.FormattingEnabled = true;
            assignmentComboBox.Location = new Point(146, 422);
            assignmentComboBox.Name = "assignmentComboBox";
            assignmentComboBox.Size = new Size(332, 28);
            assignmentComboBox.TabIndex = 12;
            // 
            // RTBContent
            // 
            RTBContent.Location = new Point(522, 464);
            RTBContent.Margin = new Padding(3, 4, 3, 4);
            RTBContent.Name = "RTBContent";
            RTBContent.Size = new Size(168, 83);
            RTBContent.TabIndex = 13;
            RTBContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 476);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 14;
            label1.Text = "Approved by";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 525);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 15;
            label3.Text = "Assigned to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 425);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 16;
            label4.Text = "Assignment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 425);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 17;
            label5.Text = "Content";
            // 
            // BTNDelete
            // 
            BTNDelete.Location = new Point(727, 516);
            BTNDelete.Name = "BTNDelete";
            BTNDelete.Size = new Size(286, 29);
            BTNDelete.TabIndex = 20;
            BTNDelete.Text = "Remove  assignment feedbase";
            BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            BTNUpdate.Location = new Point(899, 425);
            BTNUpdate.Name = "BTNUpdate";
            BTNUpdate.Size = new Size(114, 71);
            BTNUpdate.TabIndex = 19;
            BTNUpdate.Text = "Update assignment feedbase";
            BTNUpdate.UseVisualStyleBackColor = true;
            // 
            // BTNCreate
            // 
            BTNCreate.Location = new Point(727, 425);
            BTNCreate.Name = "BTNCreate";
            BTNCreate.Size = new Size(135, 73);
            BTNCreate.TabIndex = 18;
            BTNCreate.Text = "Create a assignment feedbase ";
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
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(RTBContent);
            Controls.Add(assignmentComboBox);
            Controls.Add(CBXStudent);
            Controls.Add(CBXSupervisor);
            Controls.Add(label2);
            Controls.Add(DTPCreated);
            Controls.Add(DGVDash);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Text = "DashboardView";
            Load += DashboardView_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVDash;
        private DateTimePicker DTPCreated;
        private Label label2;
        private ComboBox CBXSupervisor;
        private ComboBox CBXStudent;
        private ComboBox assignmentComboBox;
        private RichTextBox RTBContent;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BTNDelete;
        private Button BTNUpdate;
        private Button BTNCreate;
    }
}