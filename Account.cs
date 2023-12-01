using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudyDoc
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\viraj\\OneDrive\\Desktop\\C#_VS\\StudyDoc\\StudyDoc\\Database1.mdf;Integrated Security=True");
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\viraj\\OneDrive\\Desktop\\C#_VS\\StudyDoc\\StudyDoc\\Database1.mdf;Integrated Security=True");

            // Create a command object
            SqlCommand command = new SqlCommand("DELETE FROM StudyDocData WHERE username = @username", connection);

            // Add parameters to the command object
            command.Parameters.AddWithValue("@username", textBox1.Text);

            // Open the connection
            connection.Open();

            // Execute the command
            int rowsAffected = command.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            MessageBox.Show("Your Account Are Deleted!", "Account Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\viraj\\OneDrive\\Desktop\\C#_VS\\StudyDoc\\StudyDoc\\Database1.mdf;Integrated Security=True");

           
            SqlCommand command = new SqlCommand("UPDATE StudyDocData SET password = @password WHERE username = @username", connection);

            
            command.Parameters.AddWithValue("@username", textBox2.Text);
            command.Parameters.AddWithValue("@password", textBox3.Text);
           

           
            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            
            connection.Close();
            MessageBox.Show("Your Password Are Changed!","Account Setting",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
