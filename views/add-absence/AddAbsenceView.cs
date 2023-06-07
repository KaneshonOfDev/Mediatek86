using MediaTek86.controllers;
using MediaTek86.models;
using Serilog;

namespace MediaTek86.views
{
    public partial class AddAbsenceForm : Form
    {
        private MainController controller;
        private Action<Boolean> callback;
        private Staff staff;
        public BindingSource bdgMotifs = new BindingSource();
        public BindingSource bdgStaffs = new BindingSource();
        
        public AddAbsenceForm(Staff staff, Action<Boolean> callback)
        {
            InitializeComponent();
            this.controller = new MainController();
            this.staff = staff;
            this.callback = callback;
            this.fillMotifs();
            this.fillStaffs();
        }

        private void fillMotifs() {
            this.controller.SetMotifs(bdgMotifs);
            motifCb.DataSource = bdgMotifs;
            if (motifCb.Items.Count > 0)
            {
                motifCb.SelectedIndex = 0;
            }
        }

        private void fillStaffs() {
            this.controller.SetStaffs(bdgStaffs);
            staffCb.DataSource = bdgStaffs;
            if (staffCb.Items.Count > 0)
            {
                Staff? staff = null;
                foreach(Staff s in staffCb.Items) {
                    if(s.Nom == this.staff.Nom) {
                        staff = s;
                        break;
                    }
                }
                int index = staffCb.Items.IndexOf(staff);
                staffCb.SelectedIndex = index;
            }
        }

        private void handleAdd(object sender, EventArgs e) {
            if (motifCb.SelectedIndex == -1 || staffCb.SelectedIndex == -1) {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                return;
            }
            Staff staff = (Staff) staffCb.SelectedItem;
            controller.AddAbsence(staff.IdPersonnel, dtpStartDate.Value, dtpEndDate.Value, (Motif) motifCb.SelectedItem);
            this.Hide();
            this.callback?.Invoke(true);
        }

        private void handleCancel(object sender, EventArgs e) {
            this.Hide();
        }
    }
}