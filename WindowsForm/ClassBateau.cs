using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class Bateau
    {
        private string nom;
        private int nobateau;

        public Bateau(string nom, int nobateau)
        {
            this.nom = nom;
            this.nobateau = nobateau;
        }

        public override string ToString() { return this.nom; }

        public int GetNoBateau(){ return this.nobateau; }

        public string GetNom() { return this.nom; }
    }
}
