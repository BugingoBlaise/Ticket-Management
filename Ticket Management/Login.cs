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
using System.Security.Cryptography;

namespace Ticket_Management
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=BLAISEM\BLAISE;Initial Catalog=TICKETDB;Integrated Security=True");
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernameBox.Text;
            password = passwordBox.Text;

            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = md5.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }

                string hardPassword = builder.ToString();

                string querry = "select count (*) from signUp where userName ='" + usernameBox.Text + "' and password = '" + hardPassword + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows[0][0].ToString() == "1")
                {
                    // page that need to be load next

                    BookTicket bkForm = new BookTicket();
                    bkForm.Show();
                    this.Hide();
                }
                else if(usernameBox.Text == "admin" && passwordBox.Text == "111")
                {
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    
                    usernameBox.Clear();
                    passwordBox.Clear();

                    usernameBox.Focus();
                   notifierlabel.Text = "Invalid username or password";
                }
            }
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
