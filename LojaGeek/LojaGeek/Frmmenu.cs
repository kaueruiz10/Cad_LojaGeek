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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void cADASTROPRODUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
            this.Hide();
            
        }

        private void btnMenuCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
            this.Hide();
        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente consCli = new ConsultarCliente();
            consCli.Show();
        }

        private void btnMenuCons_Click(object sender, EventArgs e)
        {
            ConsultarCliente consCli = new ConsultarCliente();
            consCli.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnMenuCadProd_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.Show();
            this.Hide();
        }

        private void btnMenuConsProd_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            consultarProduto.Show();
        }
    }
}
