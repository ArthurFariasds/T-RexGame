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
    public partial class PainelGameOver : Form
    {
        string user = "";
        public PainelGameOver(string username)
        {
            InitializeComponent();

            user = username;
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e) // ao clicar no botao reiniciar ele chama o jogo que é reinicado 
        {

            JogoDino jogo = new JogoDino(user);

            this.Hide(); //ele esconde a janela apos reinicar o jogo
            jogo.Closed += (s, args) => this.Close();
            jogo.Show();//faz aparecer a tela do jogo
        }

        private void btn_Menu_Click(object sender, EventArgs e)  // ao clicar no botao menu ele volta para o menu do jogo
        {

            Menu menu = new Menu(user);

            this.Hide(); //ele esconde a janela apos voltar para o menu do jogo
            menu.Closed += (s, args) => this.Close();
            menu.Show();//faz aparecer a tela do menu
        }
    }
}
