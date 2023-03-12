namespace WindowsForm
{
    internal class Periode
    {
        private short noperiode;
        private string datedebut;
        private string datefin;

        public Periode(short noperiode, string datedebut, string datefin)
        {
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }

        public int GetNoPeriode() { return noperiode; }

        public override string ToString() { return datedebut + " au " + datefin; }
    }
}
