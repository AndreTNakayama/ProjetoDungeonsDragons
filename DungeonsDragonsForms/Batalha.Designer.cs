
namespace DungeonsDragonsForms
{
    partial class frmBatalha
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVidaHeroi = new System.Windows.Forms.Label();
            this.pgbVidaHeroi = new System.Windows.Forms.ProgressBar();
            this.btnCurar = new System.Windows.Forms.Button();
            this.lblStatusVida = new System.Windows.Forms.Label();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.lblStatusVidaInimigo = new System.Windows.Forms.Label();
            this.picMonstro = new System.Windows.Forms.PictureBox();
            this.pgbVidaMonstro = new System.Windows.Forms.ProgressBar();
            this.lblVidaInimigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonstro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVidaHeroi);
            this.groupBox1.Controls.Add(this.pgbVidaHeroi);
            this.groupBox1.Controls.Add(this.btnCurar);
            this.groupBox1.Controls.Add(this.lblStatusVida);
            this.groupBox1.Controls.Add(this.btnAtaque);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Menu de combate  ";
            // 
            // lblVidaHeroi
            // 
            this.lblVidaHeroi.AutoSize = true;
            this.lblVidaHeroi.Location = new System.Drawing.Point(251, 67);
            this.lblVidaHeroi.Name = "lblVidaHeroi";
            this.lblVidaHeroi.Size = new System.Drawing.Size(0, 13);
            this.lblVidaHeroi.TabIndex = 9;
            // 
            // pgbVidaHeroi
            // 
            this.pgbVidaHeroi.Location = new System.Drawing.Point(221, 41);
            this.pgbVidaHeroi.Name = "pgbVidaHeroi";
            this.pgbVidaHeroi.Size = new System.Drawing.Size(115, 23);
            this.pgbVidaHeroi.TabIndex = 8;
            // 
            // btnCurar
            // 
            this.btnCurar.Enabled = false;
            this.btnCurar.Location = new System.Drawing.Point(398, 41);
            this.btnCurar.Name = "btnCurar";
            this.btnCurar.Size = new System.Drawing.Size(135, 51);
            this.btnCurar.TabIndex = 3;
            this.btnCurar.Text = "Curar";
            this.btnCurar.UseVisualStyleBackColor = true;
            this.btnCurar.Click += new System.EventHandler(this.btnCurar_Click);
            // 
            // lblStatusVida
            // 
            this.lblStatusVida.AutoSize = true;
            this.lblStatusVida.Location = new System.Drawing.Point(218, 25);
            this.lblStatusVida.Name = "lblStatusVida";
            this.lblStatusVida.Size = new System.Drawing.Size(118, 13);
            this.lblStatusVida.TabIndex = 1;
            this.lblStatusVida.Text = "Status de vida do Herói";
            // 
            // btnAtaque
            // 
            this.btnAtaque.Location = new System.Drawing.Point(21, 41);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(135, 51);
            this.btnAtaque.TabIndex = 0;
            this.btnAtaque.Text = "Ataque com arma";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // lblStatusVidaInimigo
            // 
            this.lblStatusVidaInimigo.AutoSize = true;
            this.lblStatusVidaInimigo.Location = new System.Drawing.Point(427, 20);
            this.lblStatusVidaInimigo.Name = "lblStatusVidaInimigo";
            this.lblStatusVidaInimigo.Size = new System.Drawing.Size(131, 13);
            this.lblStatusVidaInimigo.TabIndex = 4;
            this.lblStatusVidaInimigo.Text = "Status de vida do Monstro";
            // 
            // picMonstro
            // 
            this.picMonstro.Image = global::DungeonsDragonsForms.Properties.Resources.Goblin;
            this.picMonstro.Location = new System.Drawing.Point(83, 20);
            this.picMonstro.Name = "picMonstro";
            this.picMonstro.Size = new System.Drawing.Size(180, 150);
            this.picMonstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonstro.TabIndex = 6;
            this.picMonstro.TabStop = false;
            // 
            // pgbVidaMonstro
            // 
            this.pgbVidaMonstro.Location = new System.Drawing.Point(430, 36);
            this.pgbVidaMonstro.Name = "pgbVidaMonstro";
            this.pgbVidaMonstro.Size = new System.Drawing.Size(128, 23);
            this.pgbVidaMonstro.TabIndex = 7;
            // 
            // lblVidaInimigo
            // 
            this.lblVidaInimigo.AutoSize = true;
            this.lblVidaInimigo.Location = new System.Drawing.Point(443, 62);
            this.lblVidaInimigo.Name = "lblVidaInimigo";
            this.lblVidaInimigo.Size = new System.Drawing.Size(0, 13);
            this.lblVidaInimigo.TabIndex = 10;
            // 
            // frmBatalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 372);
            this.Controls.Add(this.lblVidaInimigo);
            this.Controls.Add(this.pgbVidaMonstro);
            this.Controls.Add(this.picMonstro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatusVidaInimigo);
            this.Name = "frmBatalha";
            this.Text = "Batalha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonstro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVidaHeroi;
        private System.Windows.Forms.ProgressBar pgbVidaHeroi;
        private System.Windows.Forms.Button btnCurar;
        private System.Windows.Forms.Label lblStatusVida;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Label lblStatusVidaInimigo;
        private System.Windows.Forms.PictureBox picMonstro;
        private System.Windows.Forms.ProgressBar pgbVidaMonstro;
        private System.Windows.Forms.Label lblVidaInimigo;
    }
}