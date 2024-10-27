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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // se o usuario for Geek e a senha 12345 chama o menu e aparece a mensagem 
            if (txtUsuário.Text == "Geek" && txtSenha.Text == "12345")
            {
                Frmmenu menu = new Frmmenu();
                menu.Show();
                MessageBox.Show("Seja bem Vindo ao Sistema Geek Store");
                this.Hide();
            }
            else
                // se o usuario e senha forem errrada aparece essa mensagem
                MessageBox.Show("Usuário Incorreto");
        }
    }
    }
    

