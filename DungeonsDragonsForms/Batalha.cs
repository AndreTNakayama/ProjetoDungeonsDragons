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

        public double vidaMaxHeroi { get; set; }
        public double vidaMaxMonstro { get; set; }
        public Heroi HeroiAtual { get; set; }
        public Monstro MonstroAtual { get; set; }
        public frmBatalha(Heroi heroi)
        {
            this.HeroiAtual = heroi;
            InitializeComponent();
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(1, 4);

            lblStatusVida.Text = "Vida do Herói: " + heroi.Nome;
            vidaMaxHeroi = HeroiAtual.Status.Vida;
            pgbVidaHeroi.Maximum = Convert.ToInt32(vidaMaxHeroi);
            pgbVidaHeroi.Value = Convert.ToInt32(vidaMaxHeroi);
            lblVidaHeroi.Text = heroi.Status.Vida.ToString();

            if (this.HeroiAtual.Classe == "Mago"){
                btnCurar.Enabled = true;
            }
            else
            {
                btnCurar.Enabled = false;
            }

            if (sorteio.Equals(1))
            {
                MonstroAtual = new Dragao(1, new Status(50, 30, 25, 10, 200, 0, false));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.Dragao;
            }
            else if (sorteio.Equals(2))
            {
                MonstroAtual = new Goblin(1, new Status(30, 15, 20, 10, 100, 0, false));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.Goblin;
            }
            else if (sorteio.Equals(3))
            {
                MonstroAtual = new Aranha(1, new Status(20, 5, 35, 10, 60, 0, false));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.aranha;
            }

            vidaMaxMonstro = MonstroAtual.Status.Vida;
            lblVidaInimigo.Text = "Vida do monstro: " + MonstroAtual.Status.Vida.ToString();
            pgbVidaMonstro.Maximum = Convert.ToInt32(vidaMaxMonstro);
            pgbVidaMonstro.Value = Convert.ToInt32(vidaMaxMonstro);
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            if (MonstroAtual.Status.Morte == false && HeroiAtual.Status.Morte == false)
            {
                MonstroAtual.RecebeAtaque(HeroiAtual.AtaqueFinal());
                HeroiAtual.RecebeAtaque(MonstroAtual.AtaqueFinal());

                lblVidaInimigo.Text = "Vida do monstro: " + MonstroAtual.Status.Vida.ToString();
                lblVidaHeroi.Text = "Vida do Herói: " + HeroiAtual.Status.Vida.ToString();

                pgbVidaMonstro.Value = Convert.ToInt32(MonstroAtual.Status.Vida);
                pgbVidaHeroi.Value = Convert.ToInt32(HeroiAtual.Status.Vida);

                if (MonstroAtual.Status.Morte == true)
                {
                    Random numAleatorio = new Random();
                    int sorteio = numAleatorio.Next(20, 120);

                    MessageBox.Show("O monstro morreu!");
                    this.HeroiAtual.Carteira += sorteio;
                    frmAcampamento form = new frmAcampamento(vidaMaxHeroi, HeroiAtual);
                    form.Show();
                    this.Close();
                }
                if (HeroiAtual.Status.Morte == true)
                {
                    frmAcampamento form = new frmAcampamento(vidaMaxHeroi, HeroiAtual);
                    form.Show();
                    this.Close();
                }
            }
        }

        private void btnCurar_Click(object sender, EventArgs e)
        {
            this.HeroiAtual.Status.Vida = Convert.ToInt32(vidaMaxHeroi * 0.2);
        }
    }
}