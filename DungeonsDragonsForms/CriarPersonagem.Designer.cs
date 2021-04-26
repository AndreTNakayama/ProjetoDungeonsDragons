
namespace DungeonsDragonsForms
{
    partial class frmCriarPersonagem
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxClasse = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMANA = new System.Windows.Forms.TextBox();
            this.txtVIT = new System.Windows.Forms.TextBox();
            this.txtSOR = new System.Windows.Forms.TextBox();
            this.lblMANA = new System.Windows.Forms.Label();
            this.lblVIT = new System.Windows.Forms.Label();
            this.lblSOR = new System.Windows.Forms.Label();
            this.txtAGI = new System.Windows.Forms.TextBox();
            this.txtDEF = new System.Windows.Forms.TextBox();
            this.lblDEF = new System.Windows.Forms.Label();
            this.lblAGI = new System.Windows.Forms.Label();
            this.lblFOR = new System.Windows.Forms.Label();
            this.txtFOR = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbxClasse
            // 
            this.cbxClasse.FormattingEnabled = true;
            this.cbxClasse.Items.AddRange(new object[] {
            "Guerreiro",
            "Arqueiro",
            "Mago"});
            this.cbxClasse.Location = new System.Drawing.Point(54, 36);
            this.cbxClasse.Name = "cbxClasse";
            this.cbxClasse.Size = new System.Drawing.Size(206, 21);
            this.cbxClasse.TabIndex = 2;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(13, 39);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(38, 13);
            this.lblClasse.TabIndex = 3;
            this.lblClasse.Text = "Classe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMANA);
            this.groupBox1.Controls.Add(this.txtVIT);
            this.groupBox1.Controls.Add(this.txtSOR);
            this.groupBox1.Controls.Add(this.lblMANA);
            this.groupBox1.Controls.Add(this.lblVIT);
            this.groupBox1.Controls.Add(this.lblSOR);
            this.groupBox1.Controls.Add(this.txtAGI);
            this.groupBox1.Controls.Add(this.txtDEF);
            this.groupBox1.Controls.Add(this.lblDEF);
            this.groupBox1.Controls.Add(this.lblAGI);
            this.groupBox1.Controls.Add(this.lblFOR);
            this.groupBox1.Controls.Add(this.txtFOR);
            this.groupBox1.Location = new System.Drawing.Point(16, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Atributos  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Distribua 300 Pontos";
            // 
            // txtMANA
            // 
            this.txtMANA.Location = new System.Drawing.Point(169, 64);
            this.txtMANA.Name = "txtMANA";
            this.txtMANA.Size = new System.Drawing.Size(53, 20);
            this.txtMANA.TabIndex = 23;
            // 
            // txtVIT
            // 
            this.txtVIT.Location = new System.Drawing.Point(59, 168);
            this.txtVIT.Name = "txtVIT";
            this.txtVIT.Size = new System.Drawing.Size(53, 20);
            this.txtVIT.TabIndex = 20;
            // 
            // txtSOR
            // 
            this.txtSOR.Location = new System.Drawing.Point(59, 142);
            this.txtSOR.Name = "txtSOR";
            this.txtSOR.Size = new System.Drawing.Size(53, 20);
            this.txtSOR.TabIndex = 17;
            // 
            // lblMANA
            // 
            this.lblMANA.AutoSize = true;
            this.lblMANA.Location = new System.Drawing.Point(125, 67);
            this.lblMANA.Name = "lblMANA";
            this.lblMANA.Size = new System.Drawing.Size(38, 13);
            this.lblMANA.TabIndex = 14;
            this.lblMANA.Text = "MANA";
            // 
            // lblVIT
            // 
            this.lblVIT.AutoSize = true;
            this.lblVIT.Location = new System.Drawing.Point(24, 171);
            this.lblVIT.Name = "lblVIT";
            this.lblVIT.Size = new System.Drawing.Size(24, 13);
            this.lblVIT.TabIndex = 13;
            this.lblVIT.Text = "VIT";
            // 
            // lblSOR
            // 
            this.lblSOR.AutoSize = true;
            this.lblSOR.Location = new System.Drawing.Point(22, 145);
            this.lblSOR.Name = "lblSOR";
            this.lblSOR.Size = new System.Drawing.Size(30, 13);
            this.lblSOR.TabIndex = 12;
            this.lblSOR.Text = "SOR";
            // 
            // txtAGI
            // 
            this.txtAGI.Location = new System.Drawing.Point(59, 116);
            this.txtAGI.Name = "txtAGI";
            this.txtAGI.Size = new System.Drawing.Size(53, 20);
            this.txtAGI.TabIndex = 11;
            // 
            // txtDEF
            // 
            this.txtDEF.Location = new System.Drawing.Point(59, 90);
            this.txtDEF.Name = "txtDEF";
            this.txtDEF.Size = new System.Drawing.Size(53, 20);
            this.txtDEF.TabIndex = 8;
            // 
            // lblDEF
            // 
            this.lblDEF.AutoSize = true;
            this.lblDEF.Location = new System.Drawing.Point(24, 93);
            this.lblDEF.Name = "lblDEF";
            this.lblDEF.Size = new System.Drawing.Size(28, 13);
            this.lblDEF.TabIndex = 5;
            this.lblDEF.Text = "DEF";
            // 
            // lblAGI
            // 
            this.lblAGI.AutoSize = true;
            this.lblAGI.Location = new System.Drawing.Point(24, 119);
            this.lblAGI.Name = "lblAGI";
            this.lblAGI.Size = new System.Drawing.Size(25, 13);
            this.lblAGI.TabIndex = 4;
            this.lblAGI.Text = "AGI";
            // 
            // lblFOR
            // 
            this.lblFOR.AutoSize = true;
            this.lblFOR.Location = new System.Drawing.Point(24, 67);
            this.lblFOR.Name = "lblFOR";
            this.lblFOR.Size = new System.Drawing.Size(29, 13);
            this.lblFOR.TabIndex = 3;
            this.lblFOR.Text = "FOR";
            // 
            // txtFOR
            // 
            this.txtFOR.Location = new System.Drawing.Point(59, 64);
            this.txtFOR.Name = "txtFOR";
            this.txtFOR.Size = new System.Drawing.Size(53, 20);
            this.txtFOR.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(185, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCriarPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 325);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.cbxClasse);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCriarPersonagem";
            this.Text = "Criar Personagem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxClasse;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAGI;
        private System.Windows.Forms.Label lblFOR;
        private System.Windows.Forms.TextBox txtFOR;
        private System.Windows.Forms.TextBox txtMANA;
        private System.Windows.Forms.TextBox txtVIT;
        private System.Windows.Forms.TextBox txtSOR;
        private System.Windows.Forms.Label lblMANA;
        private System.Windows.Forms.Label lblVIT;
        private System.Windows.Forms.Label lblSOR;
        private System.Windows.Forms.TextBox txtAGI;
        private System.Windows.Forms.TextBox txtDEF;
        private System.Windows.Forms.Label lblDEF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
    }
}