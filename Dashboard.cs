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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void circle1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor= Cursors.Hand;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.TopLevel = false;
            panel23.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.TopLevel = false;
            panel23.Controls.Add(team);
            team.BringToFront();
            team.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Term term = new Term();
            term.TopLevel = false;
            panel23.Controls.Add(term);
            term.BringToFront();
            term.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Close();
            Browser br = new Browser();  
            br.Show();   
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://vr17code.netlify.app"; 
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vr17Website vr = new vr17Website();
            vr.TopLevel = false;
            panel23.Controls.Add(vr);
            vr.BringToFront();
            vr.Show();

        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes n = new Notes();
            n.TopLevel = false;
            panel23.Controls.Add(n);
            n.BringToFront();
            n.Show();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes n = new Notes();
            n.TopLevel = false;
            panel23.Controls.Add(n);
            n.BringToFront();
            n.Show();
        }

        private void microcontrollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes n = new Notes();
            n.TopLevel = false;
            panel23.Controls.Add(n);
            n.BringToFront();
            n.Show();
        }

        private void softwareEngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes n = new Notes();
            n.TopLevel = false;
            panel23.Controls.Add(n);
            n.BringToFront();
            n.Show();
        }

        private void javaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            javaprogram jp = new javaprogram();
            jp.TopLevel = false;
            panel23.Controls.Add(jp);
            jp.BringToFront();
            jp.Show();
        }

        private void pythonToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pythonpro pp = new pythonpro();
            pp.TopLevel = false;
            panel23.Controls.Add(pp);
            pp.BringToFront();
            pp.Show();
        }

        private void ccToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C/C++ Program Comming Soon..", "Update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cSharpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# Program Comming Soon..", "Update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlpro ap = new sqlpro();
            ap.TopLevel = false;
            panel23.Controls.Add(ap);
            ap.BringToFront();
            ap.Show();
        }

        private void htmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HTML Program Comming Soon..", "Update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void javaScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JS Program Comming Soon..", "Update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("You Want To Log Out ", "LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart(); 
                
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.TopLevel = false;
            panel23.Controls.Add(ac);
            ac.BringToFront();
            ac.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BuyPro bp = new BuyPro();
            bp.TopLevel = false;
            panel23.Controls.Add(bp);
            bp.BringToFront();
            bp.Show();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
