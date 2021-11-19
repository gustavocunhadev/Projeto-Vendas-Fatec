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
    public partial class Frmnalterarsenha : Form
    {
        public Frmnalterarsenha()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botao Enviar
                NovasenhaDAO dao = new NovasenhaDAO();

                string email = txtemail.Text;

                int codigo = dao.Mudarsenha(email);

                this.Hide();

            }
            catch (Exception)
            {

                MessageBox.Show("Insira um e-mail");

            }

        }
    }
}
