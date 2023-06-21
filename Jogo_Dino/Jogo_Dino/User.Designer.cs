namespace Jogo_Dino
{
    partial class User
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Black;
            this.btn_Entrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(35, 230);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(214, 32);
            this.btn_Entrar.TabIndex = 0;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Black;
            this.lbl_User.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.White;
            this.lbl_User.Location = new System.Drawing.Point(1, 152);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(53, 16);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "USERNAME";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(60, 155);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(253, 13);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(85, 43);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(105, 36);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(4, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 1);
            this.panel1.TabIndex = 4;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Entrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_Username;
    }
}

