using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyDoc
{
    public partial class vr17Website : Form
    {
        public vr17Website()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vr17Website vb = new vr17Website(); 
            vb.Hide(); 
            Dashboard d = new Dashboard(); 
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Wait Untill Website Are Load...","Loading...",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void vr17Website_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://vr17.netlify.app");
        }
    }
}
