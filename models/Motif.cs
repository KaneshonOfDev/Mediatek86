namespace MediaTek86.models
{
    public class Motif
    {
        private int idmotif;
        private string libelle;
        
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        public int IdMotif { get => idmotif; }

        public string Libelle { get => libelle; }
    }
}