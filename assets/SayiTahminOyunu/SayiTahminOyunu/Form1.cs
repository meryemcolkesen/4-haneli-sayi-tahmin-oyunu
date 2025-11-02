using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        int dogruSayi;
        int kalanHak;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTahmin.Text = "Tahmin (4 haneli)";
            txtTahmin.ForeColor = System.Drawing.Color.Gray;

            txtTahmin.GotFocus += (s, ev) =>
            {
                if (txtTahmin.Text == "Tahmin (4 haneli)")
                {
                    txtTahmin.Text = "";
                    txtTahmin.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtTahmin.LostFocus += (s, ev) =>
            {
                if (txtTahmin.Text == "")
                {
                    txtTahmin.Text = "Tahmin (4 haneli)";
                    txtTahmin.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTahmin.Text, out int tahmin) || tahmin < 1000 || tahmin > 9999)
            {
                MessageBox.Show(
                    "Lütfen 4 haneli sayı giriniz!",
                    "Yanlış İşlem Yaptınız!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            kalanHak--;
            lblKalanHak.Text = "Kalan Hak: " + kalanHak;

            string feedback = HesaplaFeedback(tahmin, dogruSayi);
            lstHistory.Items.Add("Tahmin: " + tahmin + " → " + feedback);

            if (tahmin == dogruSayi)
            {
                lblDurum.Visible = true;
                lblDogruSayi.Text = "Doğru sayı: " + dogruSayi;
                lblDogruSayi.Visible = true;
                txtTahmin.Enabled = false;
                btnTahminEt.Enabled = false;

            }
            else if (kalanHak == 0)
            {
                MessageBox.Show(
                    "Haklarınız bitti! Doğru sayı: " + dogruSayi,
                    "Haklarınız Bitti!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtTahmin.Enabled = false;
                btnTahminEt.Enabled = false;
            }

            txtTahmin.Text = "";
        }
        private string HesaplaFeedback(int tahmin, int dogru)
        {
            int arti = 0, eksi = 0;
            string tahminStr = tahmin.ToString();
            string dogruStr = dogru.ToString();

            for (int i = 0; i < 4; i++)
            {
                if (tahminStr[i] == dogruStr[i])
                    arti++;
                else if (dogruStr.Contains(tahminStr[i]))
                    eksi++;
            }

            return arti + "+ | " + eksi + "-";
 
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {

            dogruSayi = rnd.Next(1000, 10000);
            kalanHak = 15;

            lblKalanHak.Text = "Kalan Hak: " + (kalanHak);
            txtTahmin.Text = "";
            txtTahmin.Enabled = true;
            btnTahminEt.Enabled = true;
            lblDurum.Visible = false;
            lblDogruSayi.Visible = false;
            lstHistory.Items.Clear();

            Console.WriteLine("Yeni Doğru Sayı:" + (dogruSayi));

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
