using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace tabu2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        public static Random rastgele = new Random();
        public int rstglsayi = rastgele.Next(10);
        public static int tm=0;
        public static int scoreb;
        public static int scorer;
        public string[] isimler = { "DUY", "TAVAN", "LAMBA", "IŞIK", "İŞİTMEK" };
        public string[] isimler2 = { "HEDİYE", "ARMAĞAN", "DOĞUM GÜNÜ", "VERMEK", "MUTLU" };
        public string[] isimler3 = { "ANTİKA", "ESKİ", "MÜZAYEDE", "TABLO", "TARİHİ" };
        public string[] isimler4 = { "SATRANÇ", "PİYON", "ŞAH", "VEZİR", "AT" };
        public string[] isimler5 = { "LİNUX", "GNU", "LİNUS TORVALDS", "PENGUEN", "İŞLETİM SİSTEMİ" };
        public string[] isimler6 = { "KUMBARA", "PARA", "BİRİKTİRMEK", "BOZUK PARA", "BANKA" };
        public string[] isimler7 = { "KELEBEK", "TIRTIL", "KOZA", "HAYVAN", "UÇMAK" };
        public string[] isimler8 = { "TİYATRO", "OYUNCU", "SAHNE", "PERDE", "OYUN" };
        public string[] isimler9 = { "SAZ", "TÜRKÜ", "MÜZİK", "TEL", "BAĞLAMA" };
        public string[] isimler10 = { "FERMUAR", "MONT", "KOT", "GİYSİ", "PANTALON" };

        private void Form3_Load(object sender, EventArgs e)
        {
         
            label1.Text = Form2.bteam;
            label2.Text = Form2.rteam;
            label9.Text = Form3.scoreb.ToString();
            label10.Text = Form3.scorer.ToString();


            List<string[]> kelimeler = new List<string[]>();
            kelimeler.Add(isimler);
            kelimeler.Add(isimler2);
            kelimeler.Add(isimler3);
            kelimeler.Add(isimler4);
            kelimeler.Add(isimler5);
            kelimeler.Add(isimler6);
            kelimeler.Add(isimler7);
            kelimeler.Add(isimler8);
            kelimeler.Add(isimler9);
            kelimeler.Add(isimler10);
            label3.Text = kelimeler[rstglsayi][0];
            label4.Text = kelimeler[rstglsayi][1];
            label5.Text = kelimeler[rstglsayi][2];
            label6.Text = kelimeler[rstglsayi][3];
            label7.Text = kelimeler[rstglsayi][4];





        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            int say = int.Parse(label8.Text);
            if (say>=0)
            {
                 if (say == 0)
                {

                    Form team = new Form4();
                    team.Show();
                    this.Hide();
               
                }
                
                 say--;
                 label8.Text = say.ToString();
                

            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int pas = int.Parse(label11.Text);
            if (pas != 0)
            {
                pas--;
                label11.Text = pas.ToString();
                 Random rastgele1 = new Random();
                 int rstglsayi1 = rastgele1.Next(10);
                List<string[]> kelimeler = new List<string[]>();
                kelimeler.Add(isimler);
                kelimeler.Add(isimler2);
                kelimeler.Add(isimler3);
                kelimeler.Add(isimler4);
                kelimeler.Add(isimler5);
                kelimeler.Add(isimler6);
                kelimeler.Add(isimler7);
                kelimeler.Add(isimler8);
                kelimeler.Add(isimler9);
                kelimeler.Add(isimler10);
                label3.Text = kelimeler[rstglsayi1][0];
                label4.Text = kelimeler[rstglsayi1][1];
                label5.Text = kelimeler[rstglsayi1][2];
                label6.Text = kelimeler[rstglsayi1][3];
                label7.Text = kelimeler[rstglsayi1][4];
            }
            else
            {
                pas = 0;
                label11.Text = pas.ToString();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tm == 0)
            {
                
                Form3.scoreb = Form3.scoreb + 1;
                label9.Text = Form3.scoreb.ToString();
                Random rastgele1 = new Random();
                int rstglsayi1 = rastgele1.Next(10);
                List<string[]> kelimeler = new List<string[]>();
                kelimeler.Add(isimler);
                kelimeler.Add(isimler2);
                kelimeler.Add(isimler3);
                kelimeler.Add(isimler4);
                kelimeler.Add(isimler5);
                kelimeler.Add(isimler6);
                kelimeler.Add(isimler7);
                kelimeler.Add(isimler8);
                kelimeler.Add(isimler9);
                kelimeler.Add(isimler10);
                label3.Text = kelimeler[rstglsayi1][0];
                label4.Text = kelimeler[rstglsayi1][1];
                label5.Text = kelimeler[rstglsayi1][2];
                label6.Text = kelimeler[rstglsayi1][3];
                label7.Text = kelimeler[rstglsayi1][4];

            }
            else
            {
                
                Form3.scorer = Form3.scorer + 1;
                label10.Text = Form3.scorer.ToString();
                Random rastgele1 = new Random();
                int rstglsayi1 = rastgele1.Next(10);
                List<string[]> kelimeler = new List<string[]>();
                kelimeler.Add(isimler);
                kelimeler.Add(isimler2);
                kelimeler.Add(isimler3);
                kelimeler.Add(isimler4);
                kelimeler.Add(isimler5);
                kelimeler.Add(isimler6);
                kelimeler.Add(isimler7);
                kelimeler.Add(isimler8);
                kelimeler.Add(isimler9);
                kelimeler.Add(isimler10);
                label3.Text = kelimeler[rstglsayi1][0];
                label4.Text = kelimeler[rstglsayi1][1];
                label5.Text = kelimeler[rstglsayi1][2];
                label6.Text = kelimeler[rstglsayi1][3];
                label7.Text = kelimeler[rstglsayi1][4];
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tm == 0)
            {
                
                Form3.scoreb = Form3.scoreb - 1;
                label9.Text = Form3.scoreb.ToString();
                Random rastgele1 = new Random();
                int rstglsayi1 = rastgele1.Next(10);
                List<string[]> kelimeler = new List<string[]>();
                kelimeler.Add(isimler);
                kelimeler.Add(isimler2);
                kelimeler.Add(isimler3);
                kelimeler.Add(isimler4);
                kelimeler.Add(isimler5);
                kelimeler.Add(isimler6);
                kelimeler.Add(isimler7);
                kelimeler.Add(isimler8);
                kelimeler.Add(isimler9);
                kelimeler.Add(isimler10);
                label3.Text = kelimeler[rstglsayi1][0];
                label4.Text = kelimeler[rstglsayi1][1];
                label5.Text = kelimeler[rstglsayi1][2];
                label6.Text = kelimeler[rstglsayi1][3];
                label7.Text = kelimeler[rstglsayi1][4];

            }
            else
            {
                
                Form3.scorer--;
                label10.Text = Form3.scorer.ToString();
                Random rastgele1 = new Random();
                int rstglsayi1 = rastgele1.Next(10);
                List<string[]> kelimeler = new List<string[]>();
                kelimeler.Add(isimler);
                kelimeler.Add(isimler2);
                kelimeler.Add(isimler3);
                kelimeler.Add(isimler4);
                kelimeler.Add(isimler5);
                kelimeler.Add(isimler6);
                kelimeler.Add(isimler7);
                kelimeler.Add(isimler8);
                kelimeler.Add(isimler9);
                kelimeler.Add(isimler10);
                label3.Text = kelimeler[rstglsayi1][0];
                label4.Text = kelimeler[rstglsayi1][1];
                label5.Text = kelimeler[rstglsayi1][2];
                label6.Text = kelimeler[rstglsayi1][3];
                label7.Text = kelimeler[rstglsayi1][4];
            }
        }
    }
}
