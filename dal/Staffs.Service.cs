using MediaTek86.models;
using Serilog;

namespace MediaTek86.dal {
    class StaffsService : MService 
    {
        public StaffsService () {}

        public List<Staff> GetAllStaffs() {
            string req = "SELECT idpersonnel, p.nom AS nom, prenom, tel, mail, s.idservice AS idservice, s.nom AS service ";
            req += "FROM personnel p JOIN service s ON p.idservice = s.idservice ";
            req += "ORDER BY nom;";
            List<object[]> records = this.GetBddManager().ReqSelect(req, null);
            List<Staff> staffs = new List<Staff>();
            Log.Debug("Records.GetAllStaffs = {0}", records);
            if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Staff staff = new Staff((int)record[0], (string)record[1], (string)record[2],
                            (string)record[3], (string)record[4], (int)record[5], (string)record[6]);
                        staffs.Add(staff);
                    }
                }
            Log.Debug("Staffs.GetAllStaffs = {0}", staffs);
            return staffs;
        }

        public void AddNewStaff(string name, string firstName, string phone, string email, Service staffService) {
            string req = "INSERT INTO personnel(nom, prenom, tel, mail, idservice) ";
            req += "VALUES (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", name);
            parameters.Add("@prenom", firstName);
            parameters.Add("@tel", phone);
            parameters.Add("@mail", email);
            parameters.Add("@idservice", staffService.IdService);
            this.GetBddManager().ReqUpdate(req, parameters);
        }

        public void UpdateStaff(Staff staff) {
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", staff.IdPersonnel);
            parameters.Add("@nom", staff.Nom);
            parameters.Add("@prenom", staff.Prenom);
            parameters.Add("@tel", staff.Tel);
            parameters.Add("@mail", staff.Email);
            parameters.Add("@idservice", staff.IdService);
            this.GetBddManager().ReqUpdate(req, parameters);
        }

        public void DeleteStaff(Staff staff) {
            AbsencesService absencesService = new AbsencesService();
            absencesService.DeleteAllAbsences(staff);
            string req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", staff.IdPersonnel);
            this.GetBddManager().ReqUpdate(req, parameters);
        }
    }
}