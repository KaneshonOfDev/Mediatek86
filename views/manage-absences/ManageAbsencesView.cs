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
            this.fillAbsences();
        }

         private void fillAbsences() {
            this.controller.SetAbsences(bdgAbsences, staff);
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
        }
    }
}