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
            label1 = new Label();
            DGVFU = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVFU).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(376, 419);
            label1.Name = "label1";
            label1.Size = new Size(486, 106);
            label1.TabIndex = 0;
            label1.Text = "FeedUpView";
            // 
            // DGVFU
            // 
            DGVFU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFU.Location = new Point(26, 12);
            DGVFU.Name = "DGVFU";
            DGVFU.RowHeadersWidth = 51;
            DGVFU.RowTemplate.Height = 29;
            DGVFU.Size = new Size(981, 312);
            DGVFU.TabIndex = 1;
            // 
            // FeedupView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 575);
            Controls.Add(DGVFU);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FeedupView";
            Text = "FeedupView";
            Load += FeedupView_Load;
            ((System.ComponentModel.ISupportInitialize)DGVFU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGVFU;
    }
}