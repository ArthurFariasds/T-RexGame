using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Dino
{
    public class LoginBanco
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();

        public LoginBanco(string username)
        {
            try
            {
                command.CommandText = "INSERT INTO tblUsuario (username, score) values (@username, 0)"; //comando sql que sera jogado no banco e executado

                command.Parameters.AddWithValue("@username", username); //parametros a serer inseridos no comando

                command.Connection = conexao.conectar(); //conecta com o banco
                command.ExecuteNonQuery(); //executa o comando 

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message); //mostra caso algum erro 
            }
            finally
            {
                conexao.desconectar(); //desconecta do banco 

            }

        }


    }
}
