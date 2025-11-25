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
   
    public partial class MENU: Form
    {
        
        public MENU()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PARACEK paracekForm = new PARACEK();
            paracekForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bakiye bakiyeform = new Bakiye();
            bakiyeform.Show();
            this.Close();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void btnyatir_Click(object sender, EventArgs e)
        {
            PARAYATIR parayatirForm = new PARAYATIR();
            parayatirForm.Show();
            this.Close();

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
