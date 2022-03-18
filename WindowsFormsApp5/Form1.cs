using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a;
        public string ad;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int a = rastgele.Next(0, 30);
            guvenver.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            string sifre = textBox2.Text;
            string guvenlik = textBox3.Text;
            if (ad == "arsal" && sifre == "123" && guvenlik == guvenver.Text && checkBox1.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("doğrulamalar yanlıs");
                Application.Exit();
            }
                
        }
    }
}
