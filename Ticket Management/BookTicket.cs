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
    public partial class BookTicket : Form
    {
        public static BookTicket instance;
        public Label ticketName;
        //public Label sendEvent;
        public BookTicket()
        {
            InitializeComponent();
            viewData();
            instance = this;
            ticketName = eventName;
            //sendEvent = printEvent;
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
        private void button2_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.Show();
            UserForm.instance.printName.Text = eventName.Text;
            this.Hide();
        }

        private void eventTableView_MouseClick(object sender, MouseEventArgs e)
        {
            if (eventTableView.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in eventTableView.SelectedRows)
                {
                    //iDtextBox.Text = row.Cells[0].Value.ToString();
                    eventName.Text = row.Cells[1].Value.ToString();
                    dateLabel.Text = row.Cells[2].Value.ToString();
                    locationLabel.Text = row.Cells[3].Value.ToString();
                    performerLabel.Text = row.Cells[5].Value.ToString();
                } 
            }

            else
            {
                MessageBox.Show("Invalid selection, Please select a single row");
            }
        }
    }
}
