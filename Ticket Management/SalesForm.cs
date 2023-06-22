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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            viewData();
        }

        public void viewData()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("saleReport", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    salesDataGridView.DataSource = dtEvent;
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SearchByEvent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventAttending", inputTextBox.Text);
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    salesDataGridView.DataSource = dtEvent;
                   
                }
            }
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
