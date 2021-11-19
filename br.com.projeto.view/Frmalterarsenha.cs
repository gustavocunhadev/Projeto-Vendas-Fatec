using Projeto_Vendas_Fatec_2.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.view
{
    public partial class Frmalterarsenha : Form
    {
        public Frmalterarsenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string novasenha = textnvsenha.Text;

            if (novasenha != " ")
            {
                AlterarsenhaDAO tela = new AlterarsenhaDAO();

                tela.Alterarsenha(novasenha);

                Frmlogin login = new Frmlogin();

                login.ShowDialog();
                

            }
            else
            {

                MessageBox.Show("Insira uma senha válida!!!");

            }

        }
    }
}
