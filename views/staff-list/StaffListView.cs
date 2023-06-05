using MediaTek86.controllers;

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
            this.fillStaffs();
        }

         private void fillStaffs() {
            this.controller.SetStaffs(bdgStaffs);
            dgvPersonnels.DataSource = bdgStaffs;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.Columns["idservice"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
        }
    }
}