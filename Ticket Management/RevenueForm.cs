using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticket_Management
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
            viewPayPal();
            viewMomo();
            viewCreditCard();
        }

        public void viewCreditCard()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("viewCard", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    creditCardTable.DataSource = dtEvent;
                }
            }
        }

        public void viewMomo()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("viewMOMOs", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    momoTable.DataSource = dtEvent;
                }
            }
        }

        public void viewPayPal()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("viewPayPalss", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    paypalTable.DataSource = dtEvent;
                }
            }
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void paypalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
