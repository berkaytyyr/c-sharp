using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class PARACEK : Form
    {
        public double Bakiye;
        public PARACEK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri.Bakiye -= Convert.ToDouble(txttutar.Text);
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Veri.Bakiye -= 100;
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            Veri.Bakiye -= 200;
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            Veri.Bakiye -= 300;
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void btn400_Click(object sender, EventArgs e)
        {
            Veri.Bakiye -= 400;
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            Veri.Bakiye -= 500;
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            Veri.Bakiye -= 1000;
            MessageBox.Show("Yeni Bakiye:" + Veri.Bakiye.ToString());
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            MENU menuForm = new MENU();
            menuForm.Show();
            this.Close();
        }
    }
        
}
