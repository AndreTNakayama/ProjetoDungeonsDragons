﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsDragonsForms.Classe.Entidades
{
    class Arqueiro : Heroi
    {
        public Arqueiro(string nome, int level, Status status) : base(nome, level, status)
        {
            MessageBox.Show("Arqueiro cadastrado com sucesso!");
        }

        public override double AtaqueFinal()
        {
            throw new NotImplementedException();
        }

        public override double DefesaFinal()
        {
            throw new NotImplementedException();
        }

        public override void RecebeAtaque(double forcaInimigo)
        {
            throw new NotImplementedException();
        }
    }
}