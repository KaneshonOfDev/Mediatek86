using MediaTek86.models;
using Serilog;

namespace MediaTek86.dal {
    class MotifsService : MService 
    {
        public MotifsService () {}

        public List<Motif> GetAllMotifs() {
            string req = "SELECT * FROM motif ORDER BY libelle;";
            List<object[]> records = this.GetBddManager().ReqSelect(req, null);
            List<Motif> motifs = new List<Motif>();
            Log.Debug("Records.GetAllMotifs = {0}", records);
            if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Motif Motif = new Motif((int)record[0], (string)record[1]);
                        motifs.Add(Motif);
                    }
                }
            Log.Debug("Motifs.GetAllMotifs = {0}", motifs);
            return motifs;
        }
    }
} 