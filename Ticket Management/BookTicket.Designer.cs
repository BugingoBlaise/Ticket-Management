namespace Ticket_Management
{
    partial class BookTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTicket));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eventName = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.performerLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lk = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.eventTableView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(337, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "BOOK EVENT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.eventName);
            this.groupBox2.Controls.Add(this.eventNameLabel);
            this.groupBox2.Controls.Add(this.performerLabel);
            this.groupBox2.Controls.Add(this.locationLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lk);
            this.groupBox2.Controls.Add(this.dateLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(200, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(403, 230);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event";
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(192, 194);
            this.eventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(0, 17);
            this.eventName.TabIndex = 16;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.eventNameLabel.Location = new System.Drawing.Point(192, 165);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(95, 17);
            this.eventNameLabel.TabIndex = 15;
            this.eventNameLabel.Text = "Event Name";
            // 
            // performerLabel
            // 
            this.performerLabel.AutoSize = true;
            this.performerLabel.Location = new System.Drawing.Point(104, 194);
            this.performerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.performerLabel.Name = "performerLabel";
            this.performerLabel.Size = new System.Drawing.Size(0, 17);
            this.performerLabel.TabIndex = 14;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(19, 194);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 17);
            this.locationLabel.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(607, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(103, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Performers";
            // 
            // lk
            // 
            this.lk.AutoSize = true;
            this.lk.ForeColor = System.Drawing.Color.Teal;
            this.lk.Location = new System.Drawing.Point(19, 165);
            this.lk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(70, 17);
            this.lk.TabIndex = 10;
            this.lk.Text = "Location";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(19, 134);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 17);
            this.dateLabel.TabIndex = 9;
            // 
            // eventTableView
            // 
            this.eventTableView.AllowUserToAddRows = false;
            this.eventTableView.AllowUserToDeleteRows = false;
            this.eventTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventTableView.Location = new System.Drawing.Point(-4, 293);
            this.eventTableView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventTableView.Name = "eventTableView";
            this.eventTableView.ReadOnly = true;
            this.eventTableView.RowTemplate.Height = 31;
            this.eventTableView.Size = new System.Drawing.Size(752, 111);
            this.eventTableView.TabIndex = 13;
            this.eventTableView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventTableView_MouseClick);
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 405);
            this.Controls.Add(this.eventTableView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label performerLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lk;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView eventTableView;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label eventName;
    }
}