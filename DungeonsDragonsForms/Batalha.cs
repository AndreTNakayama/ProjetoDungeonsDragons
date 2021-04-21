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
        public Monstro Monstro{ get; set; }
        public double vidaMax{ get; set; }
        public Heroi HeroiAtual{ get; set; }
        public frmBatalha(Heroi heroi)
        {
            InitializeComponent();

            lblStatusVida.Text = "Vida do Herói: " + heroi.Nome;
            this.vidaMax = heroi.Status.Vida;

            this.HeroiAtual = heroi;
            this.Monstro = new Dragao(1, new Status(15, 20, 10, 20, 150, 0));
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            lblVidaInimigo.Text = Monstro.Status.Vida.ToString();
            this.Monstro.RecebeAtaque(HeroiAtual.AtaqueFinal());
        }
    }
}
