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
    public partial class Frmconfirmacao : Form
    {
        public Frmconfirmacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConfirmacaoDAO dao = new ConfirmacaoDAO();
            string codigo;

            codigo = textconfirmacao.Text;

            Boolean teste = dao.ConfirmarCodigo(codigo);

            if(teste == true)
            {
                Frmalterarsenha tela = new Frmalterarsenha();
                tela.ShowDialog();

            }
            else
            {
                MessageBox.Show("Codigo não condiz com o enviado!!!");
            }

        }
    }
}
