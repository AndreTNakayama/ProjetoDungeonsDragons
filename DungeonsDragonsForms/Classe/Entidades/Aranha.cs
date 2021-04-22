using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsDragonsForms.Classe.Entidades
{
    class Aranha : Monstro
    {
        public Aranha(int level, Status status) : base(level, status)
        {
            MessageBox.Show("Aranha cadastrado com sucesso!");
        }

        public override double AtaqueFinal()
        {
            Random numAleatorio = new Random();
            double sorteio = numAleatorio.Next(0, this.Status.Sorte);
            this.Ataque = ((this.Status.Forca + this.Status.Agilidade) * (1 + (sorteio / 100)));
            return this.Ataque;
        }

        public override double DefesaFinal()
        {
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(0, this.Status.Sorte);
            this.Defesa = (this.Status.Defesa + this.Status.Agilidade) * (1 + (sorteio / 100));
            return this.Defesa;
        }

        public override void RecebeAtaque(double forcaInimigo)
        {
            int resultado = Convert.ToInt32( DefesaFinal() - forcaInimigo);
            if (resultado >= 0)
            {
                Console.WriteLine("Bloqueou o ataque!");
            }
            else
            {
                this.Status.Vida += resultado;
                if (this.Status.Vida <= 0)
                    Console.WriteLine("A aranha morreu!");
            }
        }
    }
}
