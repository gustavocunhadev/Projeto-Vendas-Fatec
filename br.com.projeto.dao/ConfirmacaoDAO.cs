using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec_2.br.com.projeto.con;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Vendas_Fatec_2.br.com.projeto.dao
{
    public class ConfirmacaoDAO
    {

        private MySqlConnection conexao;

        public ConfirmacaoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }


        public Boolean ConfirmarCodigo(string codigo)
        {
            try
            {
                string sql = @"Select senha From tb_funcionario Where senha = @codigo";

                conexao.Open();

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@senha", codigo);


                DataTable Tabela = new DataTable();
                Tabela.Columns.Add("senha", typeof(string));

                DataRow[] foundRows = Tabela.Select();

                int i = foundRows.Length;

                int j = int.Parse(codigo);


                if (j == i)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }


        }

    }
}
