using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonsDragonsForms.Classe.Entidades;

namespace DungeonsDragonsForms
{
    public partial class frmMercado : Form
    {
        public Heroi HeroiAtual { get; set; }
        public frmMercado(Heroi heroi)
        {
            this.HeroiAtual = heroi;

            InitializeComponent();

            string moedas = this.HeroiAtual.Carteira.ToString();
            lblMoedas.Text = "Moedas: " + moedas;
            
            if (this.HeroiAtual.Classe == "Guerreiro")
            {
                lblMercado.Text = "Loja de Guerreiro";
                picItem1.Image = DungeonsDragonsForms.Properties.Resources.espada;
                lblItem1.Text = "Espada(70 moedas) +10 pontos de força ";
                if(this.HeroiAtual.Carteira >= 70)
                {
                    picItem1.Enabled = true;
                    lblItem1.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }

                picItem2.Image = DungeonsDragonsForms.Properties.Resources.escudo;
                lblItem2.Text = "Escudo(75 moedas) +15 pontos de Defesa";
                if (this.HeroiAtual.Carteira >= 75)
                {
                    picItem2.Enabled = true;
                    lblItem2.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }
            } 
            else if (this.HeroiAtual.Classe == "Arqueiro")
            {
                lblMercado.Text = "Loja de Arqueiro";
                picItem1.Image = DungeonsDragonsForms.Properties.Resources.arco;
                lblItem1.Text = "Arco(65 moedas) +5 de agilidade e +3 de força";
                if (this.HeroiAtual.Carteira >= 65)
                {
                    picItem2.Enabled = true;
                    lblItem2.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }
                picItem2.Image = null;
                lblItem2.Text = "";
            }
            else if (this.HeroiAtual.Classe == "Mago")
            {
                lblMercado.Text = "Loja de Mago";
                picItem1.Image = DungeonsDragonsForms.Properties.Resources.cajado;
                lblItem1.Text = "Cajado(60 moedas) +2 de força e +50 de vida";
                if (this.HeroiAtual.Carteira >= 60)
                {
                    picItem2.Enabled = true;
                    lblItem2.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }
                picItem2.Image = null;
                lblItem2.Text = "";
            }
        }

        private void lblItem1_Click(object sender, EventArgs e)
        {
            if(this.HeroiAtual.Classe == "Guerreiro"){
                MessageBox.Show("Você comprou uma Espada");
                this.HeroiAtual.Inventario.ComprarEspada();
                this.HeroiAtual.Carteira -= 70;

                if (this.HeroiAtual.Carteira >= 70)
                {
                    picItem1.Enabled = true;
                    lblItem1.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }

                if (this.HeroiAtual.Carteira >= 75)
                {
                    picItem2.Enabled = true;
                    lblItem2.Enabled = true;
                }
                else
                {
                    picItem2.Enabled = false;
                    lblItem2.Enabled = false;
                }
            }
            else if (this.HeroiAtual.Classe == "Arqueiro")
            {
                MessageBox.Show("Você comprou um Arco");
                this.HeroiAtual.Inventario.ComprarArco();
                this.HeroiAtual.Carteira -= 65;

                if (this.HeroiAtual.Carteira >= 65)
                {
                    picItem1.Enabled = true;
                    lblItem1.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }
            }
            else if (this.HeroiAtual.Classe == "Mago")
            {
                MessageBox.Show("Você comprou um Cajado");
                this.HeroiAtual.Inventario.ComprarCajado();
                this.HeroiAtual.Carteira -= 60;

                if (this.HeroiAtual.Carteira >= 60)
                {
                    picItem1.Enabled = true;
                    lblItem1.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }
            }

            string moedas = this.HeroiAtual.Carteira.ToString();
            lblMoedas.Text = "Moedas: " + moedas;
        }

        private void picItem2_Click(object sender, EventArgs e)
        {
            if (this.HeroiAtual.Classe == "Guerreiro")
            {
                MessageBox.Show("Você comprou um escudo");
                this.HeroiAtual.Inventario.ComprarEscudo();
                this.HeroiAtual.Carteira -= 75;

                if (this.HeroiAtual.Carteira >= 70)
                {
                    picItem1.Enabled = true;
                    lblItem1.Enabled = true;
                }
                else
                {
                    picItem1.Enabled = false;
                    lblItem1.Enabled = false;
                }

                if (this.HeroiAtual.Carteira >= 75)
                {
                    picItem2.Enabled = true;
                    lblItem2.Enabled = true;
                }
                else
                {
                    picItem2.Enabled = false;
                    lblItem2.Enabled = false;
                }

                string moedas = this.HeroiAtual.Carteira.ToString();
                lblMoedas.Text = "Moedas: " + moedas;
            }
        }
    }
}
