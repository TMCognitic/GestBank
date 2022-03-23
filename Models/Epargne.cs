﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne : Compte
    {
        private DateTime _dateDernierRetrait;

        public DateTime DateDernierRetrait
        {
            get
            {
                return _dateDernierRetrait;
            }

            private set
            {
                _dateDernierRetrait = value;
            }
        }

        public override void Retrait(double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);

            if(oldSolde != Solde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }
    }
}
