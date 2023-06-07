using MediaTek86.models;
using MediaTek86.controllers;

namespace MediaTek86.views
{
    public partial class ManageAbsencesForm : Form
    {
        private MainController controller;
        private Staff staff;
        private BindingSource bdgAbsences = new BindingSource();

        public ManageAbsencesForm(Staff staff)
        {
            InitializeComponent();
            this.controller = new MainController();
            this.staff = staff;
            this.fillAbsences(true);
        }

         private void fillAbsences(Boolean refresh) {
            if(!refresh) return;
            this.controller.SetAbsences(bdgAbsences, staff);
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
        }

        private void handleAddAbsence(object sender, EventArgs e) {
            AddAbsenceForm form = new AddAbsenceForm(this.staff, new Action<Boolean>(this.fillAbsences));
            form.ShowDialog();
        }

        private void handleDeleteAbsence(object sender, EventArgs e) {
            if(dgvAbsences.SelectedRows.Count != 1) {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                return;
            }
            Absence? absence = bdgAbsences.List[bdgAbsences.Position] as Absence;
            if(absence == null) {
                 MessageBox.Show("Une erreur est survenue.", "Information");
                 return;
            }
            if (MessageBox.Show("Supprimer l'absence du " + absence.DateDebut + " ?", "Confirmer", MessageBoxButtons.YesNo) == DialogResult.No) {
                return;
            }
            controller.DeleteAbsence(absence);
            this.fillAbsences(true);
        }

        private void handleEditAbsence(object sender, EventArgs e) {
            if(dgvAbsences.SelectedRows.Count != 1) {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                return;
            }
            Absence? absence = bdgAbsences.List[bdgAbsences.Position] as Absence;
            if(absence == null) {
                 MessageBox.Show("Une erreur est survenue.", "Information");
                 return;
            }
            EditAbsenceForm form = new EditAbsenceForm(absence, new Action<Boolean>(this.fillAbsences));
            form.ShowDialog();
        }

        private void handleBackToStaff(object sender, EventArgs e) {
            this.Hide();
        }
    }
}