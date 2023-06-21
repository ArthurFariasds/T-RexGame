namespace Jogo_Dino
{
    partial class JogoDino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JogoDino));
            this.Solo = new System.Windows.Forms.Panel();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.Cacto = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Placar = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cacto)).BeginInit();
            this.SuspendLayout();
            // 
            // Solo
            // 
            this.Solo.BackColor = System.Drawing.Color.Black;
            this.Solo.Location = new System.Drawing.Point(1, 223);
            this.Solo.Name = "Solo";
            this.Solo.Size = new System.Drawing.Size(788, 87);
            this.Solo.TabIndex = 0;
            // 
            // Dino
            // 
            this.Dino.BackColor = System.Drawing.Color.Transparent;
            this.Dino.Image = ((System.Drawing.Image)(resources.GetObject("Dino.Image")));
            this.Dino.Location = new System.Drawing.Point(220, 153);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(71, 70);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dino.TabIndex = 1;
            this.Dino.TabStop = false;
            // 
            // Cacto
            // 
            this.Cacto.BackColor = System.Drawing.Color.Transparent;
            this.Cacto.Image = ((System.Drawing.Image)(resources.GetObject("Cacto.Image")));
            this.Cacto.Location = new System.Drawing.Point(596, 167);
            this.Cacto.Name = "Cacto";
            this.Cacto.Size = new System.Drawing.Size(42, 56);
            this.Cacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cacto.TabIndex = 2;
            this.Cacto.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Placar
            // 
            this.Placar.AutoSize = true;
            this.Placar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placar.ForeColor = System.Drawing.Color.Black;
            this.Placar.Location = new System.Drawing.Point(498, 20);
            this.Placar.Name = "Placar";
            this.Placar.Size = new System.Drawing.Size(80, 22);
            this.Placar.TabIndex = 3;
            this.Placar.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(578, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 22);
            this.lblScore.TabIndex = 4;
            // 
            // JogoDino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(674, 307);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Placar);
            this.Controls.Add(this.Cacto);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.Solo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JogoDino";
            this.Text = "JogoDino";
            this.Load += new System.EventHandler(this.JogoDino_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Solo;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox Cacto;
        private System.Windows.Forms.Label Placar;
        public System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer Timer;
    }
}