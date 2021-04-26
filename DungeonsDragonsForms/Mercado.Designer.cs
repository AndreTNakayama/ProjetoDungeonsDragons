
namespace DungeonsDragonsForms
{
    partial class frmMercado
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
            this.lblMercado = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.picItem2 = new System.Windows.Forms.PictureBox();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.lblMoedas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMercado
            // 
            this.lblMercado.AutoSize = true;
            this.lblMercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercado.Location = new System.Drawing.Point(73, 9);
            this.lblMercado.Name = "lblMercado";
            this.lblMercado.Size = new System.Drawing.Size(78, 20);
            this.lblMercado.TabIndex = 1;
            this.lblMercado.Text = "Mercado";
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Enabled = false;
            this.lblItem1.Location = new System.Drawing.Point(31, 158);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(43, 13);
            this.lblItem1.TabIndex = 3;
            this.lblItem1.Text = "Espada";
            this.lblItem1.Click += new System.EventHandler(this.lblItem1_Click);
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Enabled = false;
            this.lblItem2.Location = new System.Drawing.Point(31, 282);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(43, 13);
            this.lblItem2.TabIndex = 5;
            this.lblItem2.Text = "Escudo";
            this.lblItem2.Click += new System.EventHandler(this.picItem2_Click);
            // 
            // picItem2
            // 
            this.picItem2.Enabled = false;
            this.picItem2.Location = new System.Drawing.Point(103, 191);
            this.picItem2.Name = "picItem2";
            this.picItem2.Size = new System.Drawing.Size(80, 80);
            this.picItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem2.TabIndex = 4;
            this.picItem2.TabStop = false;
            this.picItem2.Click += new System.EventHandler(this.picItem2_Click);
            // 
            // picItem1
            // 
            this.picItem1.Enabled = false;
            this.picItem1.Location = new System.Drawing.Point(103, 72);
            this.picItem1.Name = "picItem1";
            this.picItem1.Size = new System.Drawing.Size(80, 80);
            this.picItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem1.TabIndex = 2;
            this.picItem1.TabStop = false;
            this.picItem1.Click += new System.EventHandler(this.lblItem1_Click);
            // 
            // lblMoedas
            // 
            this.lblMoedas.AutoSize = true;
            this.lblMoedas.Location = new System.Drawing.Point(7, 41);
            this.lblMoedas.Name = "lblMoedas";
            this.lblMoedas.Size = new System.Drawing.Size(48, 13);
            this.lblMoedas.TabIndex = 6;
            this.lblMoedas.Text = "Moedas:";
            // 
            // frmMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 304);
            this.Controls.Add(this.lblMoedas);
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.picItem2);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.picItem1);
            this.Controls.Add(this.lblMercado);
            this.Name = "frmMercado";
            this.Text = "Mercado";
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMercado;
        private System.Windows.Forms.PictureBox picItem1;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.PictureBox picItem2;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblMoedas;
    }
}