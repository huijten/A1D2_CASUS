namespace A1D2_CASUS
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            childFormPanel = new Panel();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(12, 12);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1050, 521);
            childFormPanel.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 545);
            Controls.Add(childFormPanel);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
    }
}