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
    public partial class Bakiye: Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }


        private void mevcutbakiye_TextChanged(object sender, EventArgs e)
        {
            mevcutbakiye.ReadOnly = true;
        }

        private void Bakiye_Load(object sender, EventArgs e)
        {
        
          mevcutbakiye.Text = Veri.Bakiye.ToString(); 
         
        }

        private void btnmenu1_Click(object sender, EventArgs e)
        {

        }

        private void menubakiye_Click(object sender, EventArgs e)
        {
            MENU menuForm = new MENU();
            menuForm.Show();
            this.Close();
        }
    }
}
