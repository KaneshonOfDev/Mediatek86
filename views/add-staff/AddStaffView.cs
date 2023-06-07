using MediaTek86.controllers;
using MediaTek86.models;

namespace MediaTek86.views
{
    public partial class AddStaffForm : Form
    {
        private MainController controller;
        private Action<Boolean> callback;
        public BindingSource bdgServices = new BindingSource();

        public AddStaffForm(Action<Boolean> callback)
        {
            InitializeComponent();
            this.controller = new MainController();
            this.callback = callback;
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

        private void handleAddStaff(object sender, EventArgs e) {
            if (nameText.Text.Equals("") || firstNameText.Text.Equals("") || phoneText.Text.Equals("") || emailText.Text.Equals("") || serviceCb.SelectedIndex == -1) {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                return;
            }
            controller.AddStaff(nameText.Text, firstNameText.Text, phoneText.Text, emailText.Text, (Service) serviceCb.SelectedItem);
            this.Hide();
            this.callback?.Invoke(true);
        }

        private void handleCancel(object sender, EventArgs e) {
            this.Hide();
        }
    }
}