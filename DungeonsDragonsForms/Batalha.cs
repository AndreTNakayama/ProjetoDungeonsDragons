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
        public Monstro MonstroAtual { get; set; }
        public frmBatalha(Heroi heroi)
        {
            this.HeroiAtual = heroi;
            InitializeComponent();
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(1,4);
            MessageBox.Show(sorteio.ToString());

            lblStatusVida.Text = "Vida do Herói: " + heroi.Nome;
            vidaMaxHeroi = HeroiAtual.Status.Vida;
            pgbVidaHeroi.Maximum = Convert.ToInt32(vidaMaxHeroi);
            pgbVidaHeroi.Value = Convert.ToInt32(vidaMaxHeroi);
            lblVidaHeroi.Text = heroi.Status.Vida.ToString();

            if (sorteio.Equals(1))
            {
                MonstroAtual = new Dragao(1, new Status(20, 20, 20, 20, 150, 0));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.Dragao;
            }
            else if (sorteio.Equals(2))
            {
                MonstroAtual = new Goblin(1, new Status(40, 15, 20, 10, 50, 0));
                picMonstro.Image = DungeonsDragonsForms.Properties.Resources.Goblin;
            }
            else if (sorteio.Equals(3))
            {
                MonstroAtual = new Aranha(1, new Status(25, 5, 35, 10, 40, 0));
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
                    MessageBox.Show("O monstro morreu!");
                    frmAcampamento form = new frmAcampamento(vidaMaxHeroi,HeroiAtual);
                    form.Show();
                    this.Close();
                }
                if (HeroiAtual.Status.Morte == true)
                {
                    MessageBox.Show("O herói morreu!");
                    frmAcampamento form = new frmAcampamento(vidaMaxHeroi,HeroiAtual);
                    form.Show();
                    this.Close();
                }
            } 
           
        }

        private void lblVidaHeroi_Click(object sender, EventArgs e)
        {

        }
    }
}
