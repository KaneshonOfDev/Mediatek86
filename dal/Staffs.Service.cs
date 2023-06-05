using MediaTek86.models;
using Serilog;

namespace MediaTek86.dal {
    class StaffsService : MService 
    {
        public StaffsService () {}

        public List<Staff> GetAllStaffs() {
            string req = "select idpersonnel, p.nom as nom, prenom, tel, mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p JOIN service s ON p.idservice = s.idservice ";
            req += "order by nom";
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
    }
}