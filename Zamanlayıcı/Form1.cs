using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zamanlayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dakika = 0, saniye = 60, sayac;
        int gecensuresaniye = 0;

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//Her 1 saniyede bir çalışacak



            btndurdur.Enabled = false;//Başla butonuna basılmadan bitir butonu aktif olmayacak
            btndevamet.Enabled = false;

        }

       

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            gecensuresaniye = 0;
            sayac = 0;

            dakika = Convert.ToInt32(txtdakika.Text);
            progressBar1.Maximum = Convert.ToInt32(txtdakika.Text) * 60;
            progressBar1.Minimum = 0;


            timer1.Start();
            btnbaslat.Enabled = false;
            btndurdur.Enabled = true;
            btndevamet.Enabled = true;
            this.BackColor = Color.White;
        }


        private void btndevamet_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnbaslat.Enabled = false;
            btndurdur.Enabled = true;
            btndevamet.Enabled = false;
        }
         private void btndurdur_Click(object sender, EventArgs e)
         {
            timer1.Stop();


            btnbaslat.Enabled = false;
            btndurdur.Enabled = false;
            btndevamet.Enabled = true;
         }


        private void timer1_Tick(object sender, EventArgs e)
        {

            gecensuresaniye++;
            labgecensure.Text = (gecensuresaniye.ToString());

            if (sayac <= Convert.ToInt32(txtdakika.Text) * 60)
            {
                sayac++;
            }


            progressBar1.Value = sayac;


            timer1.Interval = 1000;

            saniye = saniye - 1;


            labsure.Text = ((dakika - 1).ToString() + " : " + saniye.ToString());

            if (saniye == 0)
            {
                dakika = dakika - 1;
                labsure.Text = (dakika.ToString() + " : " + saniye.ToString());
                saniye = 60;
            }
            if (dakika == 0)
            {

                saniye = 60;
                dakika = 0;
                timer1.Stop();
                this.BackColor = Color.Green;
                MessageBox.Show("Süreniz Tamamlandı...");
                btnbaslat.Enabled = true;
            }

            labsaat.Text = DateTime.Now.ToString("h:mm:ss");
        }
    }


}


