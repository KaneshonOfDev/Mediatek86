namespace MediaTek86.dal {
    class AuthenticationService : MService 
    {
        public AuthenticationService () {}

        public Boolean Login(string login, string password) {
            string req = "select * from responsable r ";
            req += "where r.login=@login and r.pwd=SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", password);
            List<object[]> records = this.GetBddManager().ReqSelect(req, parameters);
            return records.Count > 0;
        }
    }
} 