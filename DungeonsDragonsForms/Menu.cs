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
    public partial class frmMenu : Form
    {
        List<Heroi> listaDePersonagens = new List<Heroi>();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCriarPersonagem_Click(object sender, EventArgs e)
        {
            frmCriarPersonagem form = new frmCriarPersonagem();
            form.ShowDialog();
            listaDePersonagens.Add(form.Heroi);
            cbxPersonagens.Items.Add(form.Heroi.Nome);
            this.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(cbxPersonagens.SelectedIndex >= 0)
            {
                btnJogar.Enabled = true;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Heroi heroiEscolhido = listaDePersonagens[cbxPersonagens.SelectedIndex];
            frmBatalha form = new frmBatalha(heroiEscolhido);
            form.ShowDialog();

        }
    }
}
