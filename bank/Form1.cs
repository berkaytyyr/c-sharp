using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace bank
{
    



    public partial class GIRIS: Form
    {
      
        public GIRIS()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            
            string kullaniciadi = "berkay";
            string sifre = "5454";
            if (txtkullanici.Text == kullaniciadi && txtsifre.Text == sifre)
            {
                MENU menuform = new MENU();
                menuform.Show();

                this.Hide();
            }
          
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public static class Veri
    {
        public static double Bakiye { get; set; } = 22000;
    }

}
