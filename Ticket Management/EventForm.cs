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
using System.IO;

namespace Ticket_Management
{
    public partial class EventForm : Form
    {
        
        public EventForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            //updateData
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("updateEvent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    string dateString = dateTimePicker.Text;
                    DateTime date = DateTime.Parse(dateString);
                    cmd.Parameters.AddWithValue("@eventName", nametextBox.Text);
                    cmd.Parameters.AddWithValue("@eventDatetime", date);
                    cmd.Parameters.AddWithValue("@location", locationtextBox.Text);
                    cmd.Parameters.AddWithValue("@id", iDtextBox.Text);
                    cmd.Parameters.AddWithValue("@photo", getPhoto());
                    cmd.Parameters.AddWithValue("@performers", perfomersTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    viewData();
                }
            }
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                //string query = "SELECT * FROM Event";
                con.Open();
                using (SqlCommand cmd = new SqlCommand("saveEvent", con))
                
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    string dateString = dateTimePicker.Text;
                    DateTime date = DateTime.Parse(dateString);
                    cmd.Parameters.AddWithValue("@eventName", nametextBox.Text);
                    cmd.Parameters.AddWithValue("@eventDate", date);
                    cmd.Parameters.AddWithValue("@location", locationtextBox.Text);
                    cmd.Parameters.AddWithValue("@photo", getPhoto());
                    cmd.Parameters.AddWithValue("@performers", perfomersTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    viewData();
                }
            }
        }

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            uploadPictureBox.Image.Save(stream, uploadPictureBox.Image.RawFormat);

            return stream.GetBuffer();
        }

        public void viewData()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                
                con.Open();
                using (SqlCommand cmd = new SqlCommand("viewEvent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    eventTableView.DataSource = dtEvent;
                }
            }
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            viewData();
        }

        private void eventTableView_MouseClick(object sender, MouseEventArgs e)
        {

            if (eventTableView.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in eventTableView.SelectedRows)
                { 
                    iDtextBox.Text = row.Cells[0].Value.ToString();
                    nametextBox.Text = row.Cells[1].Value.ToString();
                    dateTimePicker.Text = row.Cells[2].Value.ToString();
                    locationtextBox.Text = row.Cells[3].Value.ToString();
                    perfomersTextBox.Text = row.Cells[5].Value.ToString();
                }
                }
            
            else
            {
                MessageBox.Show("Invalid selection, Please select a single row");
            }
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure U want to delete?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("deleteEvent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", iDtextBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                        viewData();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("searchEvent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchid", searchtextBox.Text);
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtEvent.Load(sdr);
                    eventTableView.DataSource = dtEvent;
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Successfully Deleted");
                    //viewData();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nametextBox.Clear();
            dateTimePicker.ResetText();
            locationtextBox.Clear();
            iDtextBox.Clear();
            searchtextBox.Clear();
            perfomersTextBox.Clear();
            uploadPictureBox.ResetText();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            if(openPicture.ShowDialog() == DialogResult.OK)
            {
                uploadPictureBox.Image = new Bitmap(openPicture.FileName);
            }
        }
        
        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
