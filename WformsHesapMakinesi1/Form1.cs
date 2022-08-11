using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WformsHesapMakinesi1
{
    public partial class Form1 : Form
    {
       

        public string operatorSecim = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        } // İŞE YARAMIYOR

        

        private void btnNokta_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + btnNokta.Text;
        }

        private  double Hesapla(string gelenOperator,string sayi1,string sayi2)
        {
            double sonuc = 0;

            switch (gelenOperator)
            {
                case "+": sonuc=Convert.ToDouble( sayi1) + Convert.ToDouble(sayi2);
                    break;
                case "x":
                    sonuc = Convert.ToDouble(sayi1) * Convert.ToDouble(sayi2);
                    break;
                case "-": 
                    sonuc = Convert.ToDouble(sayi1) - Convert.ToDouble(sayi2);
                    break;
                case "/":
                    sonuc = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);
                    break;
                default:
                    sonuc = 0;

                    break;
            }


            return sonuc;
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            string[] ekrandakiler = txtEkran.Text.Split(Convert.ToChar(operatorSecim));


       
            txtEkran.Clear();
            txtEkran.Text = Hesapla(operatorSecim, ekrandakiler[0], ekrandakiler[1]).ToString();
        }


        private void btnCE_Click(object sender, EventArgs e)
        {
            txtEkran.Clear();
            
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + btnYuzde.Text;
        }

        private void btnParantezKapat_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + btnParantezKapat.Text;
        } 

        private void btnParantezAc_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + btnParantezAc.Text;
        } 

        private void RakamOlay(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

        private void Optİşlem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
            operatorSecim = "+";
            
           
        }  // İŞE YARAMIYOR

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + "x";
            operatorSecim = "x";
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + "+";
            operatorSecim = "+";
        }

        private void btnCıkarma_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text + "-";
            operatorSecim = "-";
        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            txtEkran.Text=txtEkran.Text + "/";
            operatorSecim = "/";
        }
    }
}
