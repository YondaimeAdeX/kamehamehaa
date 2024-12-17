using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamehamehaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = new string[5] { "ali", "veli", "fatma", "berkcan", "berkay" };
            foreach (var kisi in kisiler)
            {
                listBox1.Items.Add(kisi);
            }
        }
        
        int[] sayilar = new int[20];
        private void button2_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var sayi in sayilar)
            {
                listBox2.Items.Add(sayi);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = sayilar.Max().ToString();
            //int eb = sayilar[0];
            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]>eb)
            //    {
            //        eb = sayilar[i];
            //    }
            //    label1.Text = eb.ToString();
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = sayilar.Average().ToString();
            
            //int toplam = 0;
            //foreach (var item in sayilar)
            //{
            //    toplam = toplam += item;
            //}
            //double ortalama = toplam / sayilar.Length;
            //label3.Text = ortalama.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = sayilar.Min().ToString();
            
            //int ek = sayilar[0];
            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < ek)
            //    {
            //        ek = sayilar[i];
            //    }
            //    label2.Text = ek.ToString();
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = sayilar.Sum().ToString();
        }
    }
}
