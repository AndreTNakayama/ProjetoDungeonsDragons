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
using DungeonsDragonsForms.Classe.Inventário;

namespace DungeonsDragonsForms
{
    public partial class frmCriarPersonagem : Form
    {
        public Heroi Heroi { get; set; }
        public frmCriarPersonagem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string classe = cbxClasse.SelectedItem.ToString();

            int forca = Convert.ToInt32(txtFOR.Text);
            int defesa = Convert.ToInt32(txtDEF.Text);
            int agilidade = Convert.ToInt32(txtAGI.Text);
            int sorte = Convert.ToInt32(txtSOR.Text);
            int vida = Convert.ToInt32(txtVIT.Text);
            int mana = Convert.ToInt32(txtMANA.Text);

            int pontos = forca + defesa + agilidade + sorte + vida + mana;

            if (pontos != 300)
            {
                MessageBox.Show("A soma dos atributos é diferente de 300! Distribua os pontos de forma correta!");
            }
            else
            {
                if (classe == "Guerreiro")
                {
                    this.Heroi = new Guerreiro(nome, 1, new Status(forca, defesa, agilidade, sorte, vida, mana, false), new Inventario(0, 0, 0, 0), 0);
                }
                else if (classe == "Arqueiro")
                {
                    this.Heroi = new Arqueiro(nome, 1, new Status(forca, defesa, agilidade, sorte, vida, mana, false), new Inventario(0, 0, 0, 0), 0);
                }
                else if (classe == "Mago")
                {
                    this.Heroi = new Mago(nome, 1, new Status(forca, defesa, agilidade, sorte, vida, mana, false), new Inventario(0, 0, 0, 0), 0);
                }
                this.Close();
            }
        }
    }
}