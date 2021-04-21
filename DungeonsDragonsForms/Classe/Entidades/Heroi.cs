using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsForms.Classe.Entidades
{
    abstract public class Heroi
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public Status Status { get; set; }

        public double Ataque { get; set; }
        public int Defesa { get; set; }

        public Heroi(string nome, int level, Status status)
        {
            this.Nome = nome;
            this.Level = level;
            this.Status = status;
        }

        abstract public double DefesaFinal();

        abstract public double AtaqueFinal();

        abstract public void RecebeAtaque(double forcaInimigo);
    }
}
