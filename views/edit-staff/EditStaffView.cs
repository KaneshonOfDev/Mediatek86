using MediaTek86.controllers;

namespace MediaTek86.views
{
    public partial class EditStaffForm : Form
    {
        private MainController controller;
        public BindingSource bdgService = new BindingSource();

        public EditStaffForm()
        {
            InitializeComponent();
            this.controller = new MainController();
            this.fillServices();
        }

        private void fillServices() {
            this.controller.SetServices(bdgService);
            serviceCb.DataSource = bdgService;
            if (serviceCb.Items.Count > 0)
            {
                serviceCb.SelectedIndex = 0;
            }
        }
    }
}