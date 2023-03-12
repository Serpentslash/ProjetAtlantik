using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class Secteur
    {
        private string nom;
        private int nosecteur;
        public Secteur(string nom, int nosecteur)
        {
            this.nom = nom;
            this.nosecteur = nosecteur;
        }

        public override string ToString() { return this.nom; }

        public int GetNoSecteur() { return this.nosecteur; }

        public string GetNom() { return this.nom; }
    }
}
