using MediaTek86.controllers;

namespace MediaTek86.views
{
    public partial class AddStaffForm : Form
    {
        private MainController controller;
        public BindingSource bdgServices = new BindingSource();

        public AddStaffForm()
        {
            InitializeComponent();
            this.controller = new MainController();
            this.fillServices();
        }

        private void fillServices() {
            this.controller.SetServices(bdgServices);
            serviceCb.DataSource = bdgServices;
            if (serviceCb.Items.Count > 0)
            {
                serviceCb.SelectedIndex = 0;
            }
        }
    }
}