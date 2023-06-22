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
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
            viewData();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void checkTicket()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("checkTicket", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@checkTicket", inputTextBox.Text);
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    attendanceTable.DataSource = dtEvent;
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Successfully Deleted");
                    //viewData();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            checkTicket();
        }

        public void viewData()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("viewAttendance", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    attendanceTable.DataSource = dtEvent;
                }
            }
        }
        private void confirmationButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("updateAttendance", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ticketId", inputTextBox.Text);
                    cmd.Parameters.AddWithValue("@attendance", checkBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    viewData();
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
