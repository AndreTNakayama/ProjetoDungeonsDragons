
namespace DungeonsDragonsForms
{
    partial class frmMenu
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
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.cbxPersonagens = new System.Windows.Forms.ComboBox();
            this.btnCriarPersonagem = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.AutoSize = true;
            this.lblPersonagem.Location = new System.Drawing.Point(47, 13);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(125, 13);
            this.lblPersonagem.TabIndex = 0;
            this.lblPersonagem.Text = "Selecione o Personagem";
            // 
            // cbxPersonagens
            // 
            this.cbxPersonagens.FormattingEnabled = true;
            this.cbxPersonagens.Location = new System.Drawing.Point(16, 29);
            this.cbxPersonagens.Name = "cbxPersonagens";
            this.cbxPersonagens.Size = new System.Drawing.Size(176, 21);
            this.cbxPersonagens.TabIndex = 1;
            // 
            // btnCriarPersonagem
            // 
            this.btnCriarPersonagem.Location = new System.Drawing.Point(16, 56);
            this.btnCriarPersonagem.Name = "btnCriarPersonagem";
            this.btnCriarPersonagem.Size = new System.Drawing.Size(85, 72);
            this.btnCriarPersonagem.TabIndex = 2;
            this.btnCriarPersonagem.Text = "Criar Personagem";
            this.btnCriarPersonagem.UseVisualStyleBackColor = true;
            this.btnCriarPersonagem.Click += new System.EventHandler(this.btnCriarPersonagem_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Enabled = false;
            this.btnJogar.Location = new System.Drawing.Point(107, 56);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(85, 72);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Começar a Partida";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 144);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnCriarPersonagem);
            this.Controls.Add(this.cbxPersonagens);
            this.Controls.Add(this.lblPersonagem);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonagem;
        private System.Windows.Forms.ComboBox cbxPersonagens;
        private System.Windows.Forms.Button btnCriarPersonagem;
        private System.Windows.Forms.Button btnJogar;
    }
}

