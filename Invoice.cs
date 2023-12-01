using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


namespace StudyDoc
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();    
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = "StudyDoc Store Invoice"+ "\n" +"\t\t\t\t\t\t____________"+ "\n" + " Product:-" + checkedListBox1.Text + "\n" + "Language:-" + checkedListBox2.Text + "\n"+ "Method:-" + checkedListBox3.Text + "\n" + "\t\t\t\t\t\t____________" +"\n" + "Powered by: StudyDoc  \r\nCopyright © 2023\r\n";

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);

            pictureBox2.Image = code.GetGraphic(10);
            
            if (MessageBox.Show("You Want To See Information", "QR Code Reader", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(info, "QR Code Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
