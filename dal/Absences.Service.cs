using MediaTek86.models;
using Serilog;

namespace MediaTek86.dal {
    class AbsencesService : MService 
    {
        public AbsencesService () {}

        public List<Absence> GetAllAbsences(Staff staff) {
            string req = "select p.idpersonnel, p.nom as nom, p.prenom as prenom, a.datedebut as datedebut, a.datefin as datefin, m.libelle as motif, m.idmotif as idmotif ";
            req += "from personnel p JOIN absence a ON p.idpersonnel = a.idpersonnel JOIN motif m ON a.idmotif = m.idmotif ";
            req += "where p.idpersonnel = @idpersonnel ";
            req += "order by datedebut desc";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", staff.IdPersonnel);
            List<object[]> records = this.GetBddManager().ReqSelect(req, parameters);
            List<Absence> absences = new List<Absence>();
            Log.Debug("Records.GetAllAbsences = {0}", records);
            if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Absence absence = new Absence((int)record[0], (string)record[1],(string)record[2],(DateTime)record[3], (DateTime)record[4], (int)record[6], (string)record[5]);
                        absences.Add(absence);
                    }
                }
            Log.Debug("Absences.GetAllAbsences = {0}", absences);
            return absences;
        }
    }
}