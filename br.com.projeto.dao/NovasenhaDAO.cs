using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec_2.br.com.projeto.con;
using Projeto_Vendas_Fatec_2.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.dao
{
    class NovasenhaDAO
    {
        private MySqlConnection conexao;

        public NovasenhaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public int Mudarsenha(string email)
        {

            //Gerar um código aleátorio para verificação de e-mail
            Random numAleatorio = new Random();
            int codigo = numAleatorio.Next(100000, 999999);


            try { 

                //Mudar a senha no BD
                string sql = "Update tb_funcionarios Set senha = @codigo Where email = @email";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@senha", codigo.ToString());

                conexao.Open();

                executasql.ExecuteNonQuery();

                conexao.Close();

                return codigo;

            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao acessar conta!");
                return codigo;

            }


            //E-mail remetente e depois o destinatário
            MailMessage mailMessage = new MailMessage("empresaficticia22@gmail.com", email);

            //Título do e-mail
            mailMessage.Subject = "Titulo de Exemplo";

            //Boolean que pergunta se o texto da mensagem vai ser exibido em HTML ou não
            mailMessage.IsBodyHtml = true;

            //Mensagem no corpo do e-mail escrito em HTML
            mailMessage.Body = codigo.ToString();

            //Caso tenha acentuação no título do email 
            mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");

            //Caso tenha acentuação no corpo do email 
            mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");



            //Utiliza servidor local ou de terceiros para envio de e-mail
            //Como o smtpCliente do Gmail
            //Nos parametros é inserido o post e a porta
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);


            smtpClient.UseDefaultCredentials = false;
            //Insira primeiro o email e depois a senha do remetente abaixo
            smtpClient.Credentials = new NetworkCredential("", "");


            //Protocolo de segurança
            smtpClient.EnableSsl = true;


            smtpClient.Send(mailMessage);

        }








    }
}
