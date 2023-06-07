using MediaTek86.controllers;
using MediaTek86.views;
using MediaTek86.models;
using Serilog;

namespace MediaTek86.views
{
    public partial class StaffListForm : Form
    {
        private MainController controller;
        public BindingSource bdgStaffs = new BindingSource();

        public StaffListForm()
        {
            InitializeComponent();
            this.controller = new MainController();
            this.fillStaffs(true);
        }

         private void fillStaffs(Boolean refresh) {
            if(!refresh) return;
            this.controller.SetStaffs(bdgStaffs);
            dgvPersonnels.DataSource = bdgStaffs;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.Columns["idservice"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
        }

        private void handleClickAdd(object sender, EventArgs e) {
            AddStaffForm form = new AddStaffForm(new Action<Boolean>(this.fillStaffs));
            form.ShowDialog();
        }

        private void handleDelete(object sender, EventArgs e) {
            if(dgvPersonnels.SelectedRows.Count != 1) {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                return;
            }
            Staff? staff = bdgStaffs.List[bdgStaffs.Position] as Staff;
            if(staff == null) {
                 MessageBox.Show("Une erreur est survenue.", "Information");
                 return;
            }
            if (MessageBox.Show("Supprimer " + staff.Nom + " " + staff.Prenom + " ?", "Confirmer", MessageBoxButtons.YesNo) == DialogResult.No) {
                return;
            }
            controller.DeleteStaff(staff);
            this.fillStaffs(true);
        }

        private void handleManageAbsences(object sender, EventArgs e) {
            if(dgvPersonnels.SelectedRows.Count != 1) {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                return;
            }
            Staff? staff = bdgStaffs.List[bdgStaffs.Position] as Staff;
            if(staff == null) {
                 MessageBox.Show("Une erreur est survenue.", "Information");
                 return;
            }
            ManageAbsencesForm form = new ManageAbsencesForm(staff);
            form.ShowDialog();
        }

        private void handleEdit(object sender, EventArgs e) {
            if(dgvPersonnels.SelectedRows.Count != 1) {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                return;
            }
            Staff? staff = bdgStaffs.List[bdgStaffs.Position] as Staff;
            if(staff == null) {
                 MessageBox.Show("Une erreur est survenue.", "Information");
                 return;
            }
            EditStaffForm form = new EditStaffForm(staff, new Action<Boolean>(this.fillStaffs));
            form.ShowDialog();
        }
    }
}