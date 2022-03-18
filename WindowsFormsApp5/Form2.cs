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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            label15.Text = frm.ad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam_dogru = 0;
            int toplam_yanlis = 0;
            int toplam_puan = 0;
            // soru 1 
            if (radioButton1.Checked == true)
            {
                label7.Text = ("Doğru!");
                toplam_dogru = toplam_dogru + 1;
                toplam_puan = toplam_puan + 10;
            }
            else
            {
                label7.Text = ("Yanlış");
                toplam_yanlis = toplam_yanlis + 1;
                toplam_puan = toplam_puan -10;
            }
            // soru 2
            if (radioButton3.Checked == true)
            {
                label8.Text = ("Doğru!");
                toplam_dogru = toplam_dogru + 1;
                toplam_puan = toplam_puan + 10;
            }
            else
            {
                label8.Text = ("Yanlış");
                toplam_yanlis = toplam_yanlis + 1;
                toplam_puan = toplam_puan - 10;
            }
            // soru 3
            if (radioButton6.Checked == true)
            {
                label9.Text = ("Doğru!");
                toplam_dogru = toplam_dogru + 1;
                toplam_puan = toplam_puan + 10;
            }
            else
            {
                label9.Text = ("Yanlış");
                toplam_yanlis = toplam_yanlis + 1;
                toplam_puan = toplam_puan - 10;
            }
            // başarı durumu
            if (toplam_puan <= 20)
            {
                label17.Text = "Başarısız";
            }
            if (toplam_puan > 20)
            {
                label17.Text = "Başarılı";
            }

            // diğer
            label12.Text = toplam_dogru.ToString();
            label13.Text = toplam_yanlis.ToString();
            label5.Text = toplam_puan.ToString();
        }
    }
}
