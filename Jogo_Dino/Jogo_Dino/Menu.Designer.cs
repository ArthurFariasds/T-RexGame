namespace Jogo_Dino
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.IniciarJogo = new System.Windows.Forms.Button();
            this.Ranking = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // IniciarJogo
            // 
            this.IniciarJogo.BackColor = System.Drawing.Color.Black;
            this.IniciarJogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarJogo.ForeColor = System.Drawing.Color.White;
            this.IniciarJogo.Location = new System.Drawing.Point(12, 127);
            this.IniciarJogo.Name = "IniciarJogo";
            this.IniciarJogo.Size = new System.Drawing.Size(297, 42);
            this.IniciarJogo.TabIndex = 0;
            this.IniciarJogo.Text = "JOGAR";
            this.IniciarJogo.UseVisualStyleBackColor = false;
            this.IniciarJogo.Click += new System.EventHandler(this.IniciarJogo_Click);
            // 
            // Ranking
            // 
            this.Ranking.BackColor = System.Drawing.Color.Black;
            this.Ranking.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ranking.ForeColor = System.Drawing.Color.White;
            this.Ranking.Location = new System.Drawing.Point(12, 201);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(297, 42);
            this.Ranking.TabIndex = 1;
            this.Ranking.Text = "RANKING";
            this.Ranking.UseVisualStyleBackColor = false;
            this.Ranking.Click += new System.EventHandler(this.Ranking_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.Location = new System.Drawing.Point(89, 30);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(141, 54);
            this.lbl_Menu.TabIndex = 2;
            this.lbl_Menu.Text = "MENU";
            this.lbl_Menu.Click += new System.EventHandler(this.lbl_Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(321, 293);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.IniciarJogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciarJogo;
        private System.Windows.Forms.Button Ranking;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}