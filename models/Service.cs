namespace MediaTek86.models
{
    public class Service
    {
        private int idservice;
        private string nom;
    
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public int IdService { get => idservice; }
       
        public string Nom { get => nom; }
    }
}