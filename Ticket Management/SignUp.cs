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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=BLAISEM\BLAISE;Initial Catalog=TICKETDB;Integrated Security=True");
        private void signupbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            if (password.Text == confPassword.Text)
            {



                string pass = password.Text;
                using (MD5 md5 = MD5.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(pass);
                    byte[] hash = md5.ComputeHash(bytes);
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        builder.Append(hash[i].ToString("X2"));
                    }

                    string hardPassword = builder.ToString();
                    string query = "insert into signUp values('" + userName.Text + "','" + hardPassword + "');";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();

                    MessageBox.Show("Record inserted successfully");

                    Welcome welcomeForm = new Welcome();
                    welcomeForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Mismatch password!!!");
                userName.Clear();
                password.Clear();
                confPassword.Clear();
            }
            con.Close();
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
