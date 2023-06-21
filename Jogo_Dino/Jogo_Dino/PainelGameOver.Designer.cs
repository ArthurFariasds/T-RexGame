namespace Jogo_Dino
{
    partial class PainelGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelGameOver));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.BackColor = System.Drawing.Color.Black;
            this.btn_Reiniciar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.ForeColor = System.Drawing.Color.White;
            this.btn_Reiniciar.Location = new System.Drawing.Point(151, 252);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(96, 39);
            this.btn_Reiniciar.TabIndex = 1;
            this.btn_Reiniciar.Text = "REINICIAR";
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Black;
            this.btn_Menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Location = new System.Drawing.Point(284, 252);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(96, 39);
            this.btn_Menu.TabIndex = 5;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // PainelGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 318);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelGameOver";
            this.Text = "PainelGameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Button btn_Menu;
    }
}