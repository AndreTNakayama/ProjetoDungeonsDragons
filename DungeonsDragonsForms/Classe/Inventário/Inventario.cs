using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsForms.Classe.Inventário
{
    public class Inventario
    {
        private int Espada { get; set; }
        private int Escudo { get; set; }
        private int Arco { get; set; }
        private int Cajado { get; set; }

        public void ComprarEspada()
        {
            this.Espada++;
        }

        public void ComprarEscudo()
        {
            this.Escudo++;
        }

        public void ComprarArco()
        {
            this.Arco++;
        }

        public void ComprarCajado()
        {
            this.Cajado++;
        }

        public int BuffForca()
        {
            int buff = 0;
            buff += Espada * 10;
            buff += Arco * 3;
            buff += Cajado * 2;
            return buff;
        }
        public int BuffAgi()
        {
            int buff = 0;
            buff += Arco * 5;
            return buff;
        }

        public int BuffDef()
        {
            int buff = 0;
            buff += Escudo * 10;
            return buff;
        }

        public Inventario(int espada, int escudo, int arco, int cajado)
        {
            this.Espada = espada;
            this.Escudo = escudo;
            this.Arco = arco;
            this.Cajado = cajado;
        }
    }
}
