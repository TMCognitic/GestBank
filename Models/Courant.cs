using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Courant
    {
        private string _numero;
        private double _solde;
        private Personne _titulaire;
        private double _ligneDeCredit;

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public double Solde
        {
            get
            {
                return _solde;
            }

            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            set
            {
                _titulaire = value;
            }
        }

        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }

            set
            {
                if (value < 0)
                    return; //Exception

                _ligneDeCredit = value;
            }
        }

        public void Depot(double montant)
        {
            if (montant <= 0D)
                return;

            Solde += montant;
        }

        public void Retrait(double montant)
        {
            if (montant <= 0D)
                return;

            if (Solde - montant < -LigneDeCredit)
                return;

            Solde -= montant;
        }
    }
}
