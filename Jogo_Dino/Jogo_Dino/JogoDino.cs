using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Dino
{
    public partial class JogoDino : Form
    {
        int gravidade;
        int forca = 12;
        int score = 0;
        int velocidadeCacto = 12;
        bool pulo = false;

        string user = "";

        public JogoDino(string username)
        {
            InitializeComponent();

            user = username;

            ReiniciarJogo();
        }

        public JogoDino()
        {
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Dino.Top += gravidade;

            Cacto.Left -= velocidadeCacto; //Faz com que o cacto 'ande' --> passagem do cenário

            lblScore.Text = score.ToString();

            if (Cacto.Left < 0) // Faz com que o cacto reapareça na tela
            {
                Cacto.Left = 700;
                score++;
            }

            if (pulo == true && forca < 0) //metodos para o pulo do dino
            {
                pulo = false;
            }
            if (pulo == true)//metodos para o pulo do dino
            {
                gravidade = -12;
                forca -= 1;
            }
            else//metodos para o pulo do dino
            {
                gravidade = 12;
            }

            if (Dino.Top > 153 && pulo == false)//metodos para o pulo do dino
            {
                forca = 12;
                Dino.Top = 153;
                gravidade = 0;
            }

            if (Dino.Bounds.IntersectsWith(Cacto.Bounds)) //metodo caso dino bata no cacto
            {
                Update update = new Update(lblScore.Text, user);//atualiza o banco com o placar

                PainelGameOver over = new PainelGameOver(user);//chama o painel de game over

                Timer.Stop();//para o timer

                this.Hide();//meio de fechar a janela e chamar proxima janela
                over.Closed += (s, args) => this.Close();
                over.Show(); //faz aparecer a tela do game over
            }

            if (score > 5) //conforme a pontuação vai aumentando a velocidade do jogo aumenta
            {
                velocidadeCacto = 15;
            }
            else if (score > 10) //conforme a pontuação vai aumentando a velocidade do jogo aumenta
            {
                velocidadeCacto = 20;
            }
            else if (score > 20) //conforme a pontuação vai aumentando a velocidade do jogo aumenta
            {
                velocidadeCacto = 27;
            }
            else if (score > 30) //conforme a pontuação vai aumentando a velocidade do jogo aumenta
            {
                velocidadeCacto = 30;
            }
            else if (score > 40) //conforme a pontuação vai aumentando a velocidade do jogo aumenta
            {
                velocidadeCacto = 40;
            }


        }
        private void KeyIsDown(object sender, KeyEventArgs e) // metodo em que ao apertar o espaço o dinossauro pule
        {
            if (e.KeyCode == Keys.Space && pulo == false)
            {
                pulo = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e) // metodo em que ao apertar o espaço o dinossauro pule
        {
            if (pulo == true)
            {
                pulo = false;
            }

        }
        public void ReiniciarJogo() // reinicia as variaveis para o padrao ao reiniciar o jogo
        {
            forca = 12;
            gravidade = 0;
            pulo = false;
            lblScore.Text = score.ToString();
            velocidadeCacto = 12;
            lblScore.Text += score;
            Dino.Top = 153;

            Timer.Start();
        }

        private void JogoDino_Load(object sender, EventArgs e)
        {
        }
    }
}
