using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec_2.br.com.projeto.con;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.dao
{
    public class AlterarsenhaDAO
    {


        //Atributo
        private MySqlConnection conexao;

        //Construtor
        public AlterarsenhaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public void Alterarsenha(string novasenha)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios Set senha = @novasenha Where email = @email";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@senha", novasenha);

                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();
                

                conexao.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro na mudança da senha");

            }

        }


    }
}
