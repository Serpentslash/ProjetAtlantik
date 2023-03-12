namespace WindowsForm
{
    internal class Liaison
    {
        private int noliaison;
        private int noport_depart;
        private int nosecteur;
        private int noport_arrivee;
        private double distance;
        private string nomport_depart;
        private string nomport_arrivee;

        public Liaison(int noliaison, int noport_depart, int nosecteur, int noport_arrivee, double distance, string nomport_depart, string nomport_arrivee)
        {
            this.noliaison = noliaison;
            this.noport_depart = noport_depart;
            this.nosecteur = nosecteur;
            this.noport_arrivee = noport_arrivee;
            this.distance = distance;
            this.nomport_depart = nomport_depart;
            this.nomport_arrivee = nomport_arrivee;
        }

        public int GetNoLiaison() { return noliaison; }

        public override string ToString() { return "(d)" + nomport_depart + " - (a)" + nomport_arrivee; }
    }
}
