using ClientCFC_form_P4_20160140086.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_form_P4_20160140086
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new
        ServiceReference1.MatematikaClient();
        private string tKoordinat;

        public Form1()
        {
            InitializeComponent();
            double hasilTambah = obj.Tambah(1, 2);
            double hasilkurang = obj.Kurang(3, 2);
            double hasilkali = obj.Kali(2, 2);
            double hasilbagi = obj.Bagi(2, 2);
            ServiceReference1.Koordinat a = new
            ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new
            ServiceReference1.Koordinat();
            a.X = 7;
            a.Y = 8;
            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) +
            Math.Pow(selisihY, 2));
            Console.WriteLine("Hasil Koordinat " + jarak);

            //Console.WriteLine("1 + 2 = " + hasilTambah);
            label1.Text = ("1 + 2  = ");
            label7.Text = ("" + hasilTambah);
            label2.Text = ("3 - 2 = ");
            label8.Text = ("" + hasilkurang);
            label3.Text = ("2 x 2 = ");
            label9.Text = ("" + hasilkali);
            label4.Text = ("2 : 2 = ");
            label10.Text = ("" + hasilbagi);
            label5.Text = (" hasil koordinat ");
            label11.Text = ("" + jarak);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //double hasilTambah = obj.Tambah(1, 2);
            //Console.WriteLine("1 + 2 = " + hasilTambah);
            //label1.Text = ("1 + 2 = " + hasilTambah);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
