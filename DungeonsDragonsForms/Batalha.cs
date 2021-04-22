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
    public partial class frmBatalha : Form
    {

        public double vidaMaxHeroi{ get; set; }
        public double vidaMaxMonstro { get; set; }
        public Heroi HeroiAtual{ get; set; }
        public Monstro Monstro { get; set; }
        public frmBatalha(Heroi heroi)
        {
            InitializeComponent();
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(1,3);
            MessageBox.Show(sorteio.ToString());

            lblStatusVida.Text = "Vida do Herói: " + heroi.Nome;
            this.vidaMaxHeroi = heroi.Status.Vida;
            this.HeroiAtual = heroi;
            pgbVidaHeroi.Maximum = Convert.ToInt32(vidaMaxHeroi);
            pgbVidaHeroi.Value = Convert.ToInt32(vidaMaxHeroi);
            lblVidaHeroi.Text = heroi.Status.Vida.ToString();

            if (sorteio.Equals(1))
            {
                this.Monstro = new Dragao(1, new Status(15, 20, 10, 20, 150, 0));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.Dragao;
            }
            else if (sorteio.Equals(2))
            {
                this.Monstro = new Goblin(1, new Status(30, 15, 20, 10, 50, 0));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.Goblin;
            }
            else if (sorteio.Equals(3))
            {
                this.Monstro = new Aranha(1, new Status(15, 5, 35, 10, 40, 0));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.aranha;
            }

            vidaMaxMonstro = Monstro.Status.Vida;
            lblVidaInimigo.Text = "Vida do monstro: " + Monstro.Status.Vida.ToString();
            pgbVidaMonstro.Maximum = Convert.ToInt32(vidaMaxMonstro);
            pgbVidaMonstro.Value = Convert.ToInt32(vidaMaxMonstro);
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            this.Monstro.RecebeAtaque(HeroiAtual.AtaqueFinal());
            vidaMaxMonstro = Monstro.Status.Vida;

            lblVidaInimigo.Text = "Vida do monstro: 0" ;
            lblVidaInimigo.Text = "Vida do monstro: " + Monstro.Status.Vida.ToString();

            pgbVidaMonstro.Value = Convert.ToInt32(vidaMaxMonstro);
        }

        private void lblVidaHeroi_Click(object sender, EventArgs e)
        {

        }
    }
}
