using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsDragonsForms.Classe.Inventário;

namespace DungeonsDragonsForms.Classe.Entidades
{
    abstract public class Heroi
    {
        public Status Status { get; set; }
        public string Nome { get; set; }
        public int Level { get; set; }
        public double Ataque { get; set; }
        public int Defesa { get; set; }
        public string Classe { get; set; }
        public Inventario Inventario{ get; set; }
        public int Carteira { get; set; }

        public Heroi(string nome, int level, Status status, Inventario inventario, int Carteira)
        {
            this.Nome = nome;
            this.Level = level;
            this.Status = status;
            this.Inventario = inventario;
            this.Carteira = Carteira;
        }

        abstract public double DefesaFinal();

        abstract public double AtaqueFinal();

        abstract public void RecebeAtaque(double forcaInimigo);
    }
}
