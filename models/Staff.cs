namespace MediaTek86.models
{
    public class Staff
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private int idservice;
        private string service;

        public Staff(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
            this.service = service;
        }

        public int IdPersonnel { get => idpersonnel; }
      
        public string Nom { get => nom; }
      
        public string Prenom { get => prenom; }
      
        public string Tel { get => tel; }
    
        public string Email { get => mail; }
     
        public int IdService { get => idservice; }

        public string Service { get => service; }
    }
}