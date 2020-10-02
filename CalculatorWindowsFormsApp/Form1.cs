using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            
            if (CB1.SelectedIndex == 0)
            {
                IstHasil.Items.Clear();
                IstHasil.Items.Add(string.Format("{2}", a, b, Penambahan(a, b)));
            }

            if (CB1.SelectedIndex == 1)
            {
                IstHasil.Items.Clear();
                IstHasil.Items.Add(string.Format("{2}", a, b, Pengurangan(a, b)));
            }

            if (CB1.SelectedIndex ==2)
            {
                IstHasil.Items.Clear();
                IstHasil.Items.Add(string.Format("{2}", a, b, Perkalian(a, b)));
            }

            if (CB1.SelectedIndex == 3)
            {
                IstHasil.Items.Clear();
                IstHasil.Items.Add(string.Format("{2}", a, b, Pembagian(a, b)));
            }
            
        
        }

        
    }
}

          

     
