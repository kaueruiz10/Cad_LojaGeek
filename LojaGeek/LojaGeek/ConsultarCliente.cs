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
    public partial class ConsultarCliente : Form
    {
        string caminho = @"C:\Users\Bruno\Downloads\SISTEMA LOJA GEEK\CadastroClientes\Arquivo.txt";
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Frmmenu menu = new Frmmenu();
            menu.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*declarando um lista de string*/
            List<string> linhas = new List<string>();
            /*declarando uma linha vazia*/
            string linha;

            /*usando o leitor do caminho */
            using (System.IO.StreamReader sr = new System.IO.StreamReader(caminho))
            {
                /* Enquanto a linha for diferente de nulo*/
                while ((linha = sr.ReadLine()) != null)
                {
                    /*adicionando o que foi cadastrado*/
                    linhas.Add(linha);
                }
                /*manda a lista para o listBox*/
                lsbLista.DataSource = (linhas);
            }
        }
    }
}
