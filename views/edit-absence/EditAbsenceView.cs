using MediaTek86.controllers;
using MediaTek86.models;

namespace MediaTek86.views
{
    public partial class EditAbsenceForm : Form
    {
        private MainController controller;
        private Absence absence;
        private Action<Boolean> callback;
        public BindingSource bdgMotifs = new BindingSource();

        public EditAbsenceForm(Absence absence, Action<Boolean> callback)
        {
            InitializeComponent();
            this.controller = new MainController();
            this.absence = absence;
            this.callback = callback;
            this.fillMotifs();
            this.fillTexts();
        }

        private void fillTexts() {
            dtpStartDate.Value = absence.DateDebut;
            dtpEndDate.Value = absence.DateFin;
        }

        private void fillMotifs() {
            this.controller.SetMotifs(bdgMotifs);
            motifCb.DataSource = bdgMotifs;
            if (motifCb.Items.Count > 0)
            {
                Motif? motif = null;
                foreach(Motif m in motifCb.Items) {
                    if(m.IdMotif == this.absence.IdMotif) {
                        motif = m;
                        break;
                    }
                }
                int index = motifCb.Items.IndexOf(motif);
                motifCb.SelectedIndex = index;
            }
        }

        private void handleEditAbsence(object sender, EventArgs e) {
             if (motifCb.SelectedIndex == -1) {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                return;
            }
            Motif newMotifAbsence = (Motif) motifCb.SelectedItem;
            Absence newAbsence = new Absence(absence.IdPersonnel, dtpStartDate.Value, dtpEndDate.Value, newMotifAbsence.IdMotif, newMotifAbsence.Libelle);
            
            controller.UpdateAbsence(this.absence, newAbsence);

            this.Hide();
            this.callback?.Invoke(true);
        }

        private void handleCancel(object sender, EventArgs e) {
            this.Hide();
        }
    }
}