namespace Ticket_Management
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventMenu,
            this.saleMenu,
            this.revenueMenu,
            this.attendanceMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.fileToolStripMenuItem.Text = "Report";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // eventMenu
            // 
            this.eventMenu.Name = "eventMenu";
            this.eventMenu.Size = new System.Drawing.Size(180, 22);
            this.eventMenu.Text = "Events";
            this.eventMenu.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
            // 
            // saleMenu
            // 
            this.saleMenu.Name = "saleMenu";
            this.saleMenu.Size = new System.Drawing.Size(180, 22);
            this.saleMenu.Text = "Sales";
            this.saleMenu.Click += new System.EventHandler(this.saleMenu_Click);
            // 
            // revenueMenu
            // 
            this.revenueMenu.Name = "revenueMenu";
            this.revenueMenu.Size = new System.Drawing.Size(180, 22);
            this.revenueMenu.Text = "Revenue";
            this.revenueMenu.Click += new System.EventHandler(this.revenueMenu_Click);
            // 
            // attendanceMenu
            // 
            this.attendanceMenu.Name = "attendanceMenu";
            this.attendanceMenu.Size = new System.Drawing.Size(180, 22);
            this.attendanceMenu.Text = "Attendance";
            this.attendanceMenu.Click += new System.EventHandler(this.attendanceMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 406);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminDashboard";
            this.Text = "Admin Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventMenu;
        private System.Windows.Forms.ToolStripMenuItem saleMenu;
        private System.Windows.Forms.ToolStripMenuItem revenueMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceMenu;
    }
}