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
    public partial class CadastrarProduto : Form
    {
        string caminho = @"C:\Users\Bruno\Downloads\SISTEMA LOJA GEEK\CadastroProdutos\Arquivo.txt";
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            // para o telefone foi usando um componente da caixa de ferramentas chamado mas
            if (txtCadnomeProduto.Text == "" && txtCadDesc.Text == "" && mskCodProduto.Text == "" && txtCadPagamento.Text == "")
            {
                MessageBox.Show("dados invalidos");

            }
            else
            {

                System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true);
                sw.WriteLine(txtCadnomeProduto.Text);
                sw.WriteLine(txtCadDesc.Text);
                sw.WriteLine(mskCodProduto.Text);
                sw.WriteLine(txtCadPagamento.Text);
                sw.WriteLine("*********************************");
                MessageBox.Show("Cadastro Realizado com Sucesso!!");
                sw.Close(); // Fechamos o arquivo (o salvando). 

                txtCadnomeProduto.Clear();
                txtCadDesc.Clear();
                mskCodProduto.Clear();
                txtCadPagamento.Clear();
               
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Frmmenu menu = new Frmmenu();
            menu.Show();
            this.Hide();
        }
    }
}
