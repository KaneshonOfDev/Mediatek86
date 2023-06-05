namespace MediaTek86.models
{
    public class Responsable
    {
        private string login;
        private string pwd;

        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public string Login { get => login; }

        public string Pwd { get => pwd; }
    }
}