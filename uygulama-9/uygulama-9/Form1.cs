using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketFiyatı;
            double indirimliFiyat;
            etiketFiyatı = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyatı - etiketFiyatı * 0.10;//yüzde 10 indirim
            label3.Text=indirimliFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int etiketFiyatı;
            double indirimliFiyat;
            etiketFiyatı = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyatı - etiketFiyatı * 0.25;//yüzde 25 indirim
            label3.Text = indirimliFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int etiketFiyatı;
            double indirimliFiyat;
            etiketFiyatı = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyatı - etiketFiyatı * 0.50;//yüzde 50 indirim
            label3.Text = indirimliFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketFiyatı;
            double indirimliFiyat;
            etiketFiyatı = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyatı - etiketFiyatı * 0.75;//yüzde 75 indirim
            label3.Text = indirimliFiyat.ToString();
        }
    }
}
