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
    public partial class frmAcampamento : Form
    {
        public Heroi heroiAtual { get; set; }
        public double vidaMaxHeroi { get; set; }
        public frmAcampamento(double vidaOriginalHeroi, Heroi heroi)
        {
            InitializeComponent();
            this.heroiAtual = heroi;
            vidaMaxHeroi = vidaOriginalHeroi;

            pgbVidaHeroi.Maximum = Convert.ToInt32(vidaMaxHeroi);
            pgbVidaHeroi.Value = Convert.ToInt32(heroiAtual.Status.Vida);

            heroiAtual.Status.Vida = Convert.ToInt32(vidaMaxHeroi);
            this.heroiAtual.Status.Morte = false;
        }

        private void btnBatalha_Click(object sender, EventArgs e)
        {
            frmBatalha form = new frmBatalha(heroiAtual);
            this.Close();
            form.Show();
        }

        private void frmAcampamento_Load(object sender, EventArgs e)
        {
            tmrDescanco.Enabled = true;
            tmrDescanco.Start();
            tmrDescanco.Interval = 1000;
            tmrDescanco.Tick += new EventHandler(tmrDescanco_Tick);
        }

        private void tmrDescanco_Tick(object sender, EventArgs e)
        {
            if (pgbVidaHeroi.Value != heroiAtual.Status.Vida)
            {
                pgbVidaHeroi.Value++;
            }
            else
            {
                tmrDescanco.Stop();
                btnBatalha.Enabled = true;
                btnMercado.Enabled = true;
            }
        }

        private void btnMercado_Click(object sender, EventArgs e)
        {
            frmMercado form = new frmMercado(heroiAtual);
            form.ShowDialog();
        }
    }
}
