namespace MediaTek86.models
{
    public class Absence
    {
        private int idpersonnel;
        private DateTime datedebut;
        private DateTime datefin;
        private int idmotif;
        private string motif;

        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif, string motif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
            this.motif = motif;
        }

        public int IdPersonnel { get => idpersonnel; }

        public DateTime DateDebut { get => datedebut; }

        public DateTime DateFin { get => datefin; }

        public int IdMotif { get => idmotif; }

        public string Motif { get => motif; }
    }
}