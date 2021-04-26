﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsForms.Classe.Entidades
{
    public class Status
    {
        private int _forca;
        private int _defesa;
        private int _agilidade;
        private int _sorte;
        private int _vida;
        private int _mana;
        private bool _morto;

        public int Forca
        {
            get
            {
                return this._forca;
            }
            set
            {
                if (value > 0)
                {
                    this._forca = value;
                }
            }
        }
        public int Defesa
        {
            get
            {
                return this._defesa;
            }
            set
            {
                if (value > 0)
                {
                    this._defesa = value;
                }
            }
        }
        public int Agilidade
        {
            get
            {
                return this._agilidade;
            }
            set
            {
                if (value > 0)
                {
                    this._agilidade = value;
                }
            }
        }
        public int Sorte
        {
            get
            {
                return this._sorte;
            }
            set
            {
                if (value > 0)
                {
                    this._sorte = value;
                }
            }
        }
        public int Vida
        {
            get
            {
                return this._vida;
            }
            set
            {
                if (value > 0)
                {
                    this._vida = value;
                }
                else
                {
                    this._vida = 0;
                }
            }
        }
        public int Mana
        {
            get
            {
                return this._mana;
            }
            set
            {
                if (value > 0)
                {
                    this._mana = value;
                }
            }
        }

        public bool Morte
        {
            get
            {
                return this._morto;
            }
            set
            {
                this._morto = value;
            }
        }


        public Status(int forca, int defesa, int agilidade, int sorte, int vida, int mana, bool morte)
        {
            Forca = forca;
            Defesa = defesa;
            Agilidade = agilidade;
            Sorte = sorte;
            Vida = vida;
            Mana = mana;
            Morte = morte;
        }
    }
}
