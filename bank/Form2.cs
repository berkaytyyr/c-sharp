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
    
    public partial class PARAYATIR: Form
    {
        public double Bakiye;

        public PARAYATIR()
        {
            InitializeComponent();

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnyatir_Click(object sender, EventArgs e)
        {
            double yatirilanpara;

            if (double.TryParse(txtyatir.Text, out yatirilanpara))
            {
                Veri.Bakiye += yatirilanpara;
                txtyenibakiye.Text = Veri.Bakiye.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tutar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void menuyatir_Click(object sender, EventArgs e)
        {
            MENU menuForm = new MENU();
            menuForm.Show();
            this.Close();
        }

        private void txtyenibakiye_Click(object sender, EventArgs e)
        {

        }
    }
}
