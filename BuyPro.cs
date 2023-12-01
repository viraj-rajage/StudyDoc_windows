using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyDoc
{
    public partial class BuyPro : Form
    {
        public BuyPro()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pyment Method Blocked \n Plese Use Code","Store",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pyment Method Blocked \n Plese Use Code", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pyment Method Blocked \n Plese Use Code", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pyment Method Blocked \n Plese Use Code", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "studydocsql")
            {
                
                WebClient Client = new WebClient();
                Client.DownloadFile("https://vr17.netlify.app/Z_hiden/SQL_Pack.zip", @"D:\SQL_Pack.zip");
                MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "studydocpython")
            {
               
                WebClient Client = new WebClient();
                Client.DownloadFile("https://vr17.netlify.app/Z_hiden/Volume_2/Python_25_Program_Pack.zip", @"D:\Python_25_Program_Pack.zip");
                MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "studydocquiz")
            {
                
                WebClient Client = new WebClient();
                Client.DownloadFile("https://vr17.netlify.app/Z_hiden/MINI_C_QUIZ_PROJECT.zip", @"D:\MINI_C_QUIZ_PROJECT.zip");
                MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "studydocatm")
            {
                
                WebClient Client = new WebClient();
                Client.DownloadFile("https://vr17.netlify.app/Z_hiden/MINI_C_ATM_PROJECT.zip", @"D:\MINI_C_ATM_PROJECT.zip");
                MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.Show();  
           
        }

        private void button10_Click(object sender, EventArgs e)
        { 
           
            Invoice inv = new Invoice(); 
            inv.Show();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.Show();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.Show();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
