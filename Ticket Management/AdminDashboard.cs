using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Management
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm events = new EventForm();
            events.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void revenueMenu_Click(object sender, EventArgs e)
        {
            RevenueForm revenue = new RevenueForm();
            revenue.Show();
            this.Hide();
        }

        private void customerMenu_Click(object sender, EventArgs e)
        {

        }

        private void saleMenu_Click(object sender, EventArgs e)
        {
            SalesForm sales = new SalesForm();
            sales.Show();
            this.Hide();
        }

        private void attendanceMenu_Click(object sender, EventArgs e)
        {
            AttendanceForm attendance = new AttendanceForm();
            attendance.Show();
            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
