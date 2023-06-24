namespace A1D2_CASUS.View
{
    partial class ShopView
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
            ItemShopPanel = new Panel();
            SuspendLayout();
            // 
            // ItemShopPanel
            // 
            ItemShopPanel.Location = new Point(12, 12);
            ItemShopPanel.Name = "ItemShopPanel";
            ItemShopPanel.Size = new Size(900, 250);
            ItemShopPanel.TabIndex = 0;
            // 
            // ShopView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 431);
            Controls.Add(ItemShopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShopView";
            Text = "ShopView";
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemShopPanel;
    }
}