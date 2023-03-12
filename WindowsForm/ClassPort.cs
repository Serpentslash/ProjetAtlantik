using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class Port
    {
        private string nom;
        private int noport;

        public Port(string nom, int noport)
        {
            this.nom = nom;
            this.noport = noport;
        }

        public override string ToString() { return this.nom; }

        public int GetNoPort() { return this.noport; }

        public string GetNom() { return this.nom; }
    }
}
