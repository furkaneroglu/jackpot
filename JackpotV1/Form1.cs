using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JackpotV1
{
    public partial class Form1 : Form
    {
        public int puan = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            Random rastgele = new Random();
            sayi1 = rastgele.Next(0, 4);
            sayi2 = rastgele.Next(0, 4);
            sayi3 = rastgele.Next(0, 4);
            btnResim1.ImageIndex = sayi1;
            btnResim2.ImageIndex = sayi2;
            btnResim3.ImageIndex = sayi3;
            label1.Text = puan.ToString();
            if (sayi1 == sayi2 && sayi1 == sayi3 && sayi2 == sayi3)
            {
                puan = puan + 80;
                MessageBox.Show("JACKPOT! Tebrikler +80 Puan Kazandınız.");
            }
            else
                puan = puan - 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            puan = 0;
            label1.Text = puan.ToString();
        }

        private void oyunuBitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun Bitti, Puanınız: " + puan);
            Application.Exit();
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            puan = 0;
            MessageBox.Show("Yeni Oyuna Hoş Geldiniz. Şeytanınız Bol Olsun :)");

        }
    }
}
