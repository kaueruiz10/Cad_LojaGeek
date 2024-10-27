using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGeek
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            // se o progressbar for meno que 100
            if (prgSplash.Value < 100)
            {
                // o progressbar executa 2 vezes
                prgSplash.Value = prgSplash.Value + 2;
            }
            else
            {
                //inicio e a visibilidade do time false
                tmrSplash.Enabled = false;
                this.Visible = false;

                // instancia da tela login
                FrmLogin login = new FrmLogin();
                //chamando a tela login
                login.Show();
                //ocultando a tela login               
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
