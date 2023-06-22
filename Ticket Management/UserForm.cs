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
    public partial class UserForm : Form
    {
        public static UserForm instance;
        public Label printName;

        string price;
        public UserForm()
        {
            InitializeComponent();
            instance = this;
            printName = printEvent;
            printEvent = BookTicket.instance.ticketName;
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = "5000";
            displayPriceLabel.Text = price;
            ticketTypeLabel.Text = "Regular";
        }

        private void vipTicket_CheckedChanged(object sender, EventArgs e)
        {
            price = "15000";
            displayPriceLabel.Text = price;
            ticketTypeLabel.Text = "VIP";
        }

        private void vvipTicket_CheckedChanged(object sender, EventArgs e)
        {
            price = "30000";
            displayPriceLabel.Text = price;
            ticketTypeLabel.Text = "VVIP";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numberOfTicket_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (promoCode.Text != "0000")
                {
                    totalAmount.Text = (float.Parse(displayPriceLabel.Text) * float.Parse(numberOfTicket.Text)).ToString();
                }
                else
                {
                    totalAmount.Text = (float.Parse(displayPriceLabel.Text) * float.Parse(numberOfTicket.Text)).ToString();
                    totalAmount.Text = (float.Parse(totalAmount.Text) - 2000).ToString();
                }
            }
            catch
            {

            }

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(AppConnection.getConString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("bookingCustomer", con))

                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if(promoCode.Text != "0000")
                    {
                        string noPromo = promoCode.Text;
                        noPromo = "no";
                        cmd.Parameters.AddWithValue("@customerName", customenameBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberBox.Text);
                        cmd.Parameters.AddWithValue("@nationality", nationalityComboBox2.Text);
                        cmd.Parameters.AddWithValue("@ticketType", ticketTypeLabel.Text);
                        cmd.Parameters.AddWithValue("@unitPrice", displayPriceLabel.Text);
                        cmd.Parameters.AddWithValue("@numberTicket", numberOfTicket.Text);
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount.Text);
                        cmd.Parameters.AddWithValue("@request", requestTextBox.Text);
                        cmd.Parameters.AddWithValue("@promotion ", noPromo);
                        cmd.Parameters.AddWithValue("@paymentMode", paymentComboBox.Text);
                        cmd.Parameters.AddWithValue("@eventAttending", printEvent.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Booked, promo code not accepted");
                        Welcome welcome = new Welcome();
                        welcome.Show();
                        this.Hide();
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@customerName", customenameBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberBox.Text);
                        cmd.Parameters.AddWithValue("@nationality", nationalityComboBox2.Text);
                        cmd.Parameters.AddWithValue("@ticketType", ticketTypeLabel.Text);
                        cmd.Parameters.AddWithValue("@unitPrice", displayPriceLabel.Text);
                        cmd.Parameters.AddWithValue("@numberTicket", numberOfTicket.Text);
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount.Text);
                        cmd.Parameters.AddWithValue("@request", requestTextBox.Text);
                        cmd.Parameters.AddWithValue("@promotion ", promoCode.Text);
                        cmd.Parameters.AddWithValue("@paymentMode", paymentComboBox.Text);
                        cmd.Parameters.AddWithValue("@eventAttending", printEvent.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Booked with a valid Promotion code");
                        Welcome welcome = new Welcome();
                        welcome.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void promoCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (promoCode.Text != "0000")
                {
                    totalAmount.Text = (float.Parse(displayPriceLabel.Text) * float.Parse(numberOfTicket.Text)).ToString();
                }
                else
                {
                    totalAmount.Text = (float.Parse(displayPriceLabel.Text) * float.Parse(numberOfTicket.Text)).ToString();
                    totalAmount.Text = (float.Parse(totalAmount.Text) - 2000).ToString();
                }
            }
            catch
            {

            }
        }

        private void printEvent_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BookTicket book = new BookTicket();
            book.Show();
            this.Hide();
        }
    }
}
