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
    public partial class CadastroCliente : Form
    {
        string caminho = @"C:\Users\Bruno\Downloads\SISTEMA LOJA GEEK\CadastroClientes\Arquivo.txt";
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Frmmenu menu = new Frmmenu();
            menu.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // para o telefone foi usando um componente da caixa de ferramentas chamado mas
            if (txtCadnome.Text == "" && txtCademail.Text == "" && msktelefone.Text == "" && txtCadendereco.Text == "")
            {
                MessageBox.Show("dados invalidos");

            }
            else
            {

                System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true); 
                sw.WriteLine(txtCadnome.Text);
                sw.WriteLine(txtCademail.Text);
                sw.WriteLine(msktelefone.Text);
                sw.WriteLine(txtCadendereco.Text);
                sw.WriteLine("*********************************");
                MessageBox.Show("Cadastro Realizado com Sucesso!!");
                sw.Close(); // Fechamos o arquivo (o salvando). 

                txtCadnome.Clear();
                txtCademail.Clear();
                msktelefone.Clear();
                txtCademail.Clear();
                txtCadendereco.Clear();
            }
        }
    }
    }

