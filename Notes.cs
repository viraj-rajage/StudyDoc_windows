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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://vr17.netlify.app/notes/java";
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string weburl = "https://vr17.netlify.app/notes/python";
            System.Diagnostics.Process.Start(weburl);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://vr17.netlify.app/notes/microcontroller";
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://vr17.netlify.app/notes/software";
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/JAVA_Notes/JAVA_CHAPTER_1.pdf", @"D:\JAVA_CHAPTER_1.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/JAVA_Notes/JAVA_CHAPTER_2.pdf", @"D:\JAVA_CHAPTER_2.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/JAVA_Notes/JAVA_CHAPTER_3.pdf", @"D:\JAVA_CHAPTER_3.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/JAVA_Notes/JAVA_CHAPTER_4.pdf", @"D:\JAVA_CHAPTER_4.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/JAVA_Notes/JAVA_CHAPTER_5.pdf", @"D:\JAVA_CHAPTER_5.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/PYTHON_Notes/Python_Chapter_1.pdf", @"D:\Python_Chapter_1.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/PYTHON_Notes/Python%20Chapter%202.pdf", @"D:\Python_Chapter_2.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/PYTHON_Notes/Python%20Chapter%203.pdf", @"D:\Python_Chapter_3.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Python_Chapter_4 Comming Soon","Update",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Python_Chapter_5 Comming Soon", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Microcontroller_Note/Microcontroller%208051%20Chapter_1.pdf", @"D:\Microcontroller_Chapter_1.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Microcontroller_Note/Microcontroller%208051%20Chapter_2.pdf", @"D:\Microcontroller_Chapter_2.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Se_notes/compressed/Agile%20Software%20Methodology.pdf", @"D:\Software_Eng_Chapter_1.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Se_notes/compressed/Overview%20of%20Software%20Engineering%20[Autosaved].pdf", @"D:\Software_Eng_Chapter_2.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Se_notes/compressed/Prescriptive%20Process%20Models.pdf", @"D:\Software_Eng_Chapter_3.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Se_notes/compressed/Software%20Engineering%20Practices.pdf", @"D:\Software_Eng_Chapter_4.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://vr17.netlify.app/Se_notes/compressed/Software%20modeling.pdf", @"D:\Software_Eng_Chapter_5.pdf");
            MessageBox.Show("File Downlod", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download File Saved In D Drive","Note",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
