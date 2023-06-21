using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Jogo_Dino
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        public void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")//verifica se a text box foi iniciado vazia. Caso seja verdade mostra MessageBox
            {
                MessageBox.Show("Insira um Username", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoginBanco lgn = new LoginBanco(txt_Username.Text);

                Menu menu = new Menu(txt_Username.Text);

                this.Hide(); //meio de fechar a janela e chamar proxima janela
                menu.Closed += (s, args) => this.Close();
                menu.Show(); //faz aparecer a tela do menu
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
        }

        public void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Username.MaxLength = 12; //limita os caracteres que podem ser inseridos na textBox
        }

    }
}
