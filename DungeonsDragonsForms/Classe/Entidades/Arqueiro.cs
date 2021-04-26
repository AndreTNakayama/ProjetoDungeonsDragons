using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonsDragonsForms.Classe.Inventário;

namespace DungeonsDragonsForms.Classe.Entidades
{
    class Arqueiro : Heroi
    {
        public Arqueiro(string nome, int level, Status status, Inventario inventario, int carteira) : base(nome, level, status, inventario, carteira)
        {
            MessageBox.Show("Arqueiro cadastrado com sucesso!");
            Classe = "Arqueiro";
        }

        public override double AtaqueFinal()
        {
            Random numAleatorio = new Random();
            double sorteio = numAleatorio.Next(0, this.Status.Sorte);
            this.Ataque = ((this.Status.Forca + this.Inventario.BuffForca()) + this.Status.Agilidade) * (1 + (sorteio / 100));
            return this.Ataque;
        }

        public override double DefesaFinal()
        {
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(0, this.Status.Sorte);
            this.Defesa = ((this.Status.Defesa + Inventario.BuffDef()) + this.Status.Agilidade) * (1 + (sorteio / 100));
            return this.Defesa;
        }

        public override void RecebeAtaque(double forcaInimigo)
        {
            int resultado = Convert.ToInt32(DefesaFinal() - forcaInimigo);
            if (resultado >= 0)
            {
                MessageBox.Show("Bloqueou o ataque!");
            }
            else
            {
                this.Status.Vida += resultado;
                MessageBox.Show("O Herói sofreu " + (-resultado) + " de dano!");

                if (this.Status.Vida <= 0)
                {
                    MessageBox.Show("O Herói morreu!");
                    this.Status.Morte = true;
                }
            }
        }
    }
}
