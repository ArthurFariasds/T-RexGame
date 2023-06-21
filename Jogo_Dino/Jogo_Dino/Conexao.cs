using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jogo_Dino
{
    public class Conexao
    {

        SqlConnection connection = new SqlConnection();

        public Conexao()
        {
            connection.ConnectionString = @"Data Source=DESKTOP-9HKDNOC\SQLSERVER;Initial Catalog=JogoDino;Integrated Security=True";//endereço do banco de dados para que seja possivel conectar
        }

        // metodo que conecta com o banco de dados 
        public SqlConnection conectar()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open(); //abre a conexao
            }

            return connection;
        }

        //metodo que desconecta o banco de dados
        public void desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close(); //fecha a conexao
            }
        }






    }
}
