using MediaTek86.models;
using Serilog;

namespace MediaTek86.dal {
    class AbsencesService : MService 
    {
        public AbsencesService () {}

        public List<Absence> GetAllAbsences(Staff staff) {
            string req = "SELECT p.idpersonnel, a.datedebut AS datedebut, a.datefin AS datefin, m.libelle AS motif, m.idmotif AS idmotif ";
            req += "FROM personnel p JOIN absence a ON p.idpersonnel = a.idpersonnel JOIN motif m ON a.idmotif = m.idmotif ";
            req += "WHERE p.idpersonnel = @idpersonnel ";
            req += "ORDER BY datedebut DESC;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", staff.IdPersonnel);
            List<object[]> records = this.GetBddManager().ReqSelect(req, parameters);
            List<Absence> absences = new List<Absence>();
            Log.Debug("Records.GetAllAbsences = {0}", records);
            if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Absence absence = new Absence((int)record[0],(DateTime)record[1], (DateTime)record[2], (int)record[4], (string)record[3]);
                        absences.Add(absence);
                    }
                }
            Log.Debug("Absences.GetAllAbsences = {0}", absences);
            return absences;
        }

         public void AddNewAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif) {
            string req = "INSERT INTO absence(idpersonnel, datedebut, datefin, idmotif) ";
            req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            parameters.Add("@datedebut", datedebut);
            parameters.Add("@datefin", datefin);
            parameters.Add("@idmotif", motif.IdMotif);
            this.GetBddManager().ReqUpdate(req, parameters);
        }

        public void UpdateAbsence(Absence absence, Absence newAbsence) {
            string req = "UPDATE absence SET datedebut = @newdatedebut, datefin = @newdatefin, idmotif = @newidmotif ";
            req += "WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin AND idmotif = @idmotif;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@newdatedebut", newAbsence.DateDebut);
            parameters.Add("@newdatefin", newAbsence.DateFin);
            parameters.Add("@newidmotif", newAbsence.IdMotif);
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.IdMotif);
            this.GetBddManager().ReqUpdate(req, parameters);
        }

        public void DeleteAllAbsences(Staff staff) {
            string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", staff.IdPersonnel);
            this.GetBddManager().ReqUpdate(req, parameters);
        }

        public void DeleteAbsence(Absence absence) {
            string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND idmotif = @idmotif AND datedebut = @datedebut AND datefin = @datefin;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.IdMotif);
            this.GetBddManager().ReqUpdate(req, parameters);
        }
    }
}