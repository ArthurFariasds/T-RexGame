using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Jogo_Dino
{
    public partial class Ranking : Form
    {
        string user = "";
        public Ranking(string username)
        {
            InitializeComponent();

            user = username;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(user);

            this.Hide(); //meio de fechar a janela e chamar proxima janela
            menu.Closed += (s, args) => this.Close();
            menu.Show(); //faz aparecer a tela do menu
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand command = new SqlCommand();

            try
            {
                int cont = 1;
                string msg = string.Empty;
                command.Connection = conexao.conectar();
                command.CommandText = "SELECT TOP 3 username, score FROM tblUsuario ORDER BY score DESC"; //comando sql que sera jogado no banco e executado
                SqlDataReader dataReader = command.ExecuteReader(); //dataReader lê o banco
                List<User> users = new List<User>();

                while (dataReader.Read()) //salva na lista as informações do banco 
                {
                    User user = new User();
                    user.txt_Username.Text = dataReader["username"].ToString();
                    users.Add(user);
                }

                dataReader.Close();

                foreach (User player in users)//lê a lista e armazena na variavel msg
                {
                    msg += $"{cont} => {player.txt_Username.Text}\n";
                    cont++;
                }

                lblGetRanking.Text = msg; //os valores da msg é passada para o lblGetRanking e desse modo exibido na tela

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

        private void lblGetRanking_Click(object sender, EventArgs e)
        {
            
        }
    }
}
