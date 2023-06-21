using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Dino
{
    public partial class Menu : Form
    {
       
        string user = ""; //variavel auxiliar que recebe o username cadastrado
        public Menu(string username)
        {
            InitializeComponent();

            user = username;
        }

        private void IniciarJogo_Click(object sender, EventArgs e) // ao clicar no botao ele inicia o jogo 
        {
            JogoDino jogo = new JogoDino(user);

            this.Hide(); //ele esconde a janela apos inicar o jogo
            jogo.Closed += (s, args) => this.Close();
            jogo.Show(); //faz aparecer a tela do jogo
        }

        private void Ranking_Click(object sender, EventArgs e) // ao clicar no botao ele vai para a tela de ranking
        {
            Ranking ranking = new Ranking(user);

            this.Hide(); //ele esconde a janela apos chamar a tela de ranking 
            ranking.Closed += (s, args) => this.Close();
            ranking.Show(); //faz aparecer a tela do ranking
        }

        private void lbl_Menu_Click(object sender, EventArgs e)
        {

        }
    }
}
