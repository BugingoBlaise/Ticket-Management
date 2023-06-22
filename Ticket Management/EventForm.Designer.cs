namespace Ticket_Management
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.perfomersTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.iDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelEvent = new System.Windows.Forms.Button();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.updateEvent = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.searchEvent = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.locationtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventTableView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.perfomersTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.uploadPictureBox);
            this.groupBox1.Controls.Add(this.iDtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deleteEvent);
            this.groupBox1.Controls.Add(this.updateEvent);
            this.groupBox1.Controls.Add(this.addEvent);
            this.groupBox1.Controls.Add(this.locationtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(649, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Info";
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(16, 11);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 26);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // perfomersTextBox
            // 
            this.perfomersTextBox.Location = new System.Drawing.Point(438, 95);
            this.perfomersTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.perfomersTextBox.Multiline = true;
            this.perfomersTextBox.Name = "perfomersTextBox";
            this.perfomersTextBox.Size = new System.Drawing.Size(221, 26);
            this.perfomersTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Performers:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(516, 147);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(95, 34);
            this.browseButton.TabIndex = 26;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uploadPictureBox.Image")));
            this.uploadPictureBox.Location = new System.Drawing.Point(435, 147);
            this.uploadPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(70, 34);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadPictureBox.TabIndex = 25;
            this.uploadPictureBox.TabStop = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(128, 11);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(62, 26);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // iDtextBox
            // 
            this.iDtextBox.Enabled = false;
            this.iDtextBox.Location = new System.Drawing.Point(112, 29);
            this.iDtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iDtextBox.Multiline = true;
            this.iDtextBox.Name = "iDtextBox";
            this.iDtextBox.Size = new System.Drawing.Size(221, 26);
            this.iDtextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Event ID:";
            // 
            // cancelEvent
            // 
            this.cancelEvent.Location = new System.Drawing.Point(219, 12);
            this.cancelEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelEvent.Name = "cancelEvent";
            this.cancelEvent.Size = new System.Drawing.Size(104, 25);
            this.cancelEvent.TabIndex = 21;
            this.cancelEvent.Text = "EXIT";
            this.cancelEvent.UseVisualStyleBackColor = true;
            this.cancelEvent.Click += new System.EventHandler(this.button5_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(457, 241);
            this.deleteEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(104, 25);
            this.deleteEvent.TabIndex = 20;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // updateEvent
            // 
            this.updateEvent.Location = new System.Drawing.Point(247, 241);
            this.updateEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateEvent.Name = "updateEvent";
            this.updateEvent.Size = new System.Drawing.Size(104, 25);
            this.updateEvent.TabIndex = 19;
            this.updateEvent.Text = "Update Event";
            this.updateEvent.UseVisualStyleBackColor = true;
            this.updateEvent.Click += new System.EventHandler(this.button3_Click);
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(65, 241);
            this.addEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(104, 25);
            this.addEvent.TabIndex = 18;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // searchEvent
            // 
            this.searchEvent.Location = new System.Drawing.Point(496, 14);
            this.searchEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchEvent.Name = "searchEvent";
            this.searchEvent.Size = new System.Drawing.Size(104, 25);
            this.searchEvent.TabIndex = 17;
            this.searchEvent.Text = "Search";
            this.searchEvent.UseVisualStyleBackColor = true;
            this.searchEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(376, 13);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(116, 26);
            this.searchtextBox.TabIndex = 16;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // locationtextBox
            // 
            this.locationtextBox.Location = new System.Drawing.Point(435, 29);
            this.locationtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationtextBox.Multiline = true;
            this.locationtextBox.Name = "locationtextBox";
            this.locationtextBox.Size = new System.Drawing.Size(194, 26);
            this.locationtextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Location:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(125, 159);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 22);
            this.dateTimePicker.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date & Time:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(112, 89);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(221, 26);
            this.nametextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name:";
            // 
            // eventTableView
            // 
            this.eventTableView.AllowUserToAddRows = false;
            this.eventTableView.AllowUserToDeleteRows = false;
            this.eventTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventTableView.Location = new System.Drawing.Point(7, 326);
            this.eventTableView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventTableView.Name = "eventTableView";
            this.eventTableView.ReadOnly = true;
            this.eventTableView.RowTemplate.Height = 31;
            this.eventTableView.Size = new System.Drawing.Size(665, 118);
            this.eventTableView.TabIndex = 1;
            this.eventTableView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventTableView_MouseClick);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 455);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.eventTableView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cancelEvent);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.searchEvent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelEvent;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button updateEvent;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button searchEvent;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.TextBox locationtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView eventTableView;
        private System.Windows.Forms.TextBox iDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.TextBox perfomersTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homeButton;
    }
}