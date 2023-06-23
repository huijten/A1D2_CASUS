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
            PaddingLeftPanel = new Panel();
            paddingRightPanel = new Panel();
            paddingTopPanel = new Panel();
            headerPanel = new Panel();
            headerLbl = new Label();
            paddingHeaderPanel = new Panel();
            paddingBottomPanel = new Panel();
            navPanel = new Panel();
            backButtonPanel = new Panel();
            shopBtn = new Button();
            feedguyBtn = new Button();
            assignmentBtn = new Button();
            feedforwardBtn = new Button();
            feedbackBtn = new Button();
            feedupBtn = new Button();
            dashboardBtn = new Button();
            paddingNavPanel = new Panel();
            userPanel = new Panel();
            paddingMidPanel = new Panel();
            titlePanel = new Panel();
            titleLbl = new Label();
            childFormPanel = new Panel();
            headerPanel.SuspendLayout();
            navPanel.SuspendLayout();
            backButtonPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // PaddingLeftPanel
            // 
            PaddingLeftPanel.Dock = DockStyle.Left;
            PaddingLeftPanel.Location = new Point(0, 0);
            PaddingLeftPanel.Name = "PaddingLeftPanel";
            PaddingLeftPanel.Size = new Size(16, 750);
            PaddingLeftPanel.TabIndex = 0;
            // 
            // paddingRightPanel
            // 
            paddingRightPanel.Dock = DockStyle.Right;
            paddingRightPanel.Location = new Point(1351, 0);
            paddingRightPanel.Name = "paddingRightPanel";
            paddingRightPanel.Size = new Size(20, 750);
            paddingRightPanel.TabIndex = 1;
            // 
            // paddingTopPanel
            // 
            paddingTopPanel.Dock = DockStyle.Top;
            paddingTopPanel.Location = new Point(16, 0);
            paddingTopPanel.Name = "paddingTopPanel";
            paddingTopPanel.Size = new Size(1335, 20);
            paddingTopPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(72, 156, 130);
            headerPanel.Controls.Add(headerLbl);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(16, 20);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1335, 60);
            headerPanel.TabIndex = 3;
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            headerLbl.ForeColor = Color.White;
            headerLbl.Location = new Point(6, 4);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(271, 54);
            headerLbl.TabIndex = 0;
            headerLbl.Text = "FEEDBUF 2.0";
            // 
            // paddingHeaderPanel
            // 
            paddingHeaderPanel.Dock = DockStyle.Top;
            paddingHeaderPanel.Location = new Point(16, 80);
            paddingHeaderPanel.Name = "paddingHeaderPanel";
            paddingHeaderPanel.Size = new Size(1335, 20);
            paddingHeaderPanel.TabIndex = 4;
            // 
            // paddingBottomPanel
            // 
            paddingBottomPanel.Dock = DockStyle.Bottom;
            paddingBottomPanel.Location = new Point(16, 730);
            paddingBottomPanel.Name = "paddingBottomPanel";
            paddingBottomPanel.Size = new Size(1335, 20);
            paddingBottomPanel.TabIndex = 6;
            // 
            // navPanel
            // 
            navPanel.BackColor = SystemColors.Control;
            navPanel.Controls.Add(backButtonPanel);
            navPanel.Controls.Add(paddingNavPanel);
            navPanel.Controls.Add(userPanel);
            navPanel.Dock = DockStyle.Left;
            navPanel.Location = new Point(16, 100);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(253, 630);
            navPanel.TabIndex = 7;
            // 
            // backButtonPanel
            // 
            backButtonPanel.BackColor = Color.White;
            backButtonPanel.Controls.Add(shopBtn);
            backButtonPanel.Controls.Add(feedguyBtn);
            backButtonPanel.Controls.Add(assignmentBtn);
            backButtonPanel.Controls.Add(feedforwardBtn);
            backButtonPanel.Controls.Add(feedbackBtn);
            backButtonPanel.Controls.Add(feedupBtn);
            backButtonPanel.Controls.Add(dashboardBtn);
            backButtonPanel.Dock = DockStyle.Fill;
            backButtonPanel.Location = new Point(0, 145);
            backButtonPanel.Name = "backButtonPanel";
            backButtonPanel.Size = new Size(253, 485);
            backButtonPanel.TabIndex = 2;
            // 
            // shopBtn
            // 
            shopBtn.Dock = DockStyle.Bottom;
            shopBtn.FlatAppearance.BorderSize = 0;
            shopBtn.FlatStyle = FlatStyle.Flat;
            shopBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            shopBtn.Location = new Point(0, 430);
            shopBtn.Name = "shopBtn";
            shopBtn.Size = new Size(253, 55);
            shopBtn.TabIndex = 5;
            shopBtn.Text = "SHOP";
            shopBtn.UseVisualStyleBackColor = true;
            // 
            // feedguyBtn
            // 
            feedguyBtn.Dock = DockStyle.Top;
            feedguyBtn.FlatAppearance.BorderSize = 0;
            feedguyBtn.FlatStyle = FlatStyle.Flat;
            feedguyBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            feedguyBtn.Location = new Point(0, 275);
            feedguyBtn.Name = "feedguyBtn";
            feedguyBtn.Size = new Size(253, 55);
            feedguyBtn.TabIndex = 4;
            feedguyBtn.Text = "FEEDGUY";
            feedguyBtn.UseVisualStyleBackColor = true;
            // 
            // assignmentBtn
            // 
            assignmentBtn.Dock = DockStyle.Top;
            assignmentBtn.FlatAppearance.BorderSize = 0;
            assignmentBtn.FlatStyle = FlatStyle.Flat;
            assignmentBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            assignmentBtn.Location = new Point(0, 220);
            assignmentBtn.Name = "assignmentBtn";
            assignmentBtn.Size = new Size(253, 55);
            assignmentBtn.TabIndex = 2;
            assignmentBtn.Text = "ASSIGNMENT";
            assignmentBtn.UseVisualStyleBackColor = true;
            // 
            // feedforwardBtn
            // 
            feedforwardBtn.Dock = DockStyle.Top;
            feedforwardBtn.FlatAppearance.BorderSize = 0;
            feedforwardBtn.FlatStyle = FlatStyle.Flat;
            feedforwardBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            feedforwardBtn.Location = new Point(0, 165);
            feedforwardBtn.Name = "feedforwardBtn";
            feedforwardBtn.Size = new Size(253, 55);
            feedforwardBtn.TabIndex = 3;
            feedforwardBtn.Text = "FEEDFORWARD";
            feedforwardBtn.UseVisualStyleBackColor = true;
            // 
            // feedbackBtn
            // 
            feedbackBtn.Dock = DockStyle.Top;
            feedbackBtn.FlatAppearance.BorderSize = 0;
            feedbackBtn.FlatStyle = FlatStyle.Flat;
            feedbackBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            feedbackBtn.Location = new Point(0, 110);
            feedbackBtn.Name = "feedbackBtn";
            feedbackBtn.Size = new Size(253, 55);
            feedbackBtn.TabIndex = 3;
            feedbackBtn.Text = "FEEDBACK";
            feedbackBtn.UseVisualStyleBackColor = true;
            // 
            // feedupBtn
            // 
            feedupBtn.Dock = DockStyle.Top;
            feedupBtn.FlatAppearance.BorderSize = 0;
            feedupBtn.FlatStyle = FlatStyle.Flat;
            feedupBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            feedupBtn.Location = new Point(0, 55);
            feedupBtn.Name = "feedupBtn";
            feedupBtn.Size = new Size(253, 55);
            feedupBtn.TabIndex = 1;
            feedupBtn.Text = "FEEDUP";
            feedupBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Dock = DockStyle.Top;
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardBtn.Location = new Point(0, 0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(253, 55);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "DASHBOARD";
            dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // paddingNavPanel
            // 
            paddingNavPanel.Dock = DockStyle.Top;
            paddingNavPanel.Location = new Point(0, 125);
            paddingNavPanel.Name = "paddingNavPanel";
            paddingNavPanel.Size = new Size(253, 20);
            paddingNavPanel.TabIndex = 1;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.White;
            userPanel.Dock = DockStyle.Top;
            userPanel.Location = new Point(0, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(253, 125);
            userPanel.TabIndex = 0;
            // 
            // paddingMidPanel
            // 
            paddingMidPanel.Dock = DockStyle.Left;
            paddingMidPanel.Location = new Point(269, 100);
            paddingMidPanel.Name = "paddingMidPanel";
            paddingMidPanel.Size = new Size(20, 630);
            paddingMidPanel.TabIndex = 8;
            // 
            // titlePanel
            // 
            titlePanel.Controls.Add(titleLbl);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(289, 100);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1062, 55);
            titlePanel.TabIndex = 9;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.Location = new Point(6, 11);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(206, 41);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "DASHBOARD";
            // 
            // childFormPanel
            // 
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Location = new Point(289, 155);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1062, 575);
            childFormPanel.TabIndex = 10;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 750);
            Controls.Add(childFormPanel);
            Controls.Add(titlePanel);
            Controls.Add(paddingMidPanel);
            Controls.Add(navPanel);
            Controls.Add(paddingBottomPanel);
            Controls.Add(paddingHeaderPanel);
            Controls.Add(headerPanel);
            Controls.Add(paddingTopPanel);
            Controls.Add(paddingRightPanel);
            Controls.Add(PaddingLeftPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            navPanel.ResumeLayout(false);
            backButtonPanel.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PaddingLeftPanel;
        private Panel paddingRightPanel;
        private Panel paddingTopPanel;
        private Panel headerPanel;
        private Panel paddingHeaderPanel;
        private Panel paddingBottomPanel;
        private Panel navPanel;
        private Panel userPanel;
        private Panel backButtonPanel;
        private Panel paddingNavPanel;
        private Panel paddingMidPanel;
        private Panel titlePanel;
        private Panel childFormPanel;
        private Button dashboardBtn;
        private Button assignmentBtn;
        private Button feedforwardBtn;
        private Button feedbackBtn;
        private Button feedupBtn;
        private Button shopBtn;
        private Button feedguyBtn;
        private Label titleLbl;
        private Label headerLbl;
    }
}