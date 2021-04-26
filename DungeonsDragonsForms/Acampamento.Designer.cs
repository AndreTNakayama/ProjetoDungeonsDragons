namespace DungeonsDragonsForms
{
    partial class frmAcampamento
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
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.btnBatalha = new System.Windows.Forms.Button();
            this.btnMercado = new System.Windows.Forms.Button();
            this.pgbVidaHeroi = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrDescanco = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.Location = new System.Drawing.Point(126, 9);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(272, 20);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "Você chegou  ao acampamento! ";
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(12, 41);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(501, 13);
            this.lblEscolha.TabIndex = 1;
            this.lblEscolha.Text = "Espere o Herói se recuperar para a próxima batalha ou vá ao mercado se equipar ma" +
    "is!";
            // 
            // btnBatalha
            // 
            this.btnBatalha.Enabled = false;
            this.btnBatalha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalha.Location = new System.Drawing.Point(12, 100);
            this.btnBatalha.Name = "btnBatalha";
            this.btnBatalha.Size = new System.Drawing.Size(144, 51);
            this.btnBatalha.TabIndex = 2;
            this.btnBatalha.Text = "Ir para a Batalha";
            this.btnBatalha.UseVisualStyleBackColor = true;
            this.btnBatalha.Click += new System.EventHandler(this.btnBatalha_Click);
            // 
            // btnMercado
            // 
            this.btnMercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercado.Location = new System.Drawing.Point(369, 100);
            this.btnMercado.Name = "btnMercado";
            this.btnMercado.Size = new System.Drawing.Size(144, 51);
            this.btnMercado.TabIndex = 3;
            this.btnMercado.Text = "Ir para o Mercado";
            this.btnMercado.UseVisualStyleBackColor = true;
            this.btnMercado.Click += new System.EventHandler(this.btnMercado_Click);
            // 
            // pgbVidaHeroi
            // 
            this.pgbVidaHeroi.Location = new System.Drawing.Point(192, 112);
            this.pgbVidaHeroi.Name = "pgbVidaHeroi";
            this.pgbVidaHeroi.Size = new System.Drawing.Size(140, 29);
            this.pgbVidaHeroi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vida do Herói se recuperando...";
            // 
            // tmrDescanco
            // 
            this.tmrDescanco.Tick += new System.EventHandler(this.tmrDescanco_Tick);
            // 
            // frmAcampamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbVidaHeroi);
            this.Controls.Add(this.btnMercado);
            this.Controls.Add(this.btnBatalha);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.lblBoasVindas);
            this.Name = "frmAcampamento";
            this.Text = "Acampamento";
            this.Load += new System.EventHandler(this.frmAcampamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Button btnBatalha;
        private System.Windows.Forms.Button btnMercado;
        private System.Windows.Forms.ProgressBar pgbVidaHeroi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrDescanco;
    }
}