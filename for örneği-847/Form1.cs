using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_örneği_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int aranan = Convert.ToInt32(txtAranan.Text);
            bool bulundu = false;
            for ( int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayilar.Items[i]);

                if( sayi == aranan)
                {
                    bulundu = true;
                    break; // bu komut döngüden cıkarır...
                }
            }

            if (bulundu)
            {
                MessageBox.Show("aranan sayı bulundu");
            }
            else
            {
                MessageBox.Show("aranan sayı YOK");
            }
        }
    }
}
