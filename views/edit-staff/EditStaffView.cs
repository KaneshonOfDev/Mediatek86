using MediaTek86.controllers;
using MediaTek86.models;

namespace MediaTek86.views
{
    public partial class EditStaffForm : Form
    {
        private MainController controller;
        private Staff staff;
        private Action<Boolean> callback;
        public BindingSource bdgService = new BindingSource();

        public EditStaffForm(Staff staff, Action<Boolean> callback)
        {
            InitializeComponent();
            this.controller = new MainController();
            this.staff = staff;
            this.callback = callback;
            this.fillServices();
            this.fillTexts();
        }

        private void fillTexts() {
            nameText.Text = staff.Nom;
            firstNameText.Text = staff.Prenom;
            phoneText.Text = staff.Tel;
            emailText.Text = staff.Email;
            serviceCb.SelectedIndex = (staff.IdService - 1);
        }

        private void fillServices() {
            this.controller.SetServices(bdgService);
            serviceCb.DataSource = bdgService;
            if (serviceCb.Items.Count > 0)
            {
                serviceCb.SelectedIndex = 0;
            }
        }

        private void handleEditStaff(object sender, EventArgs e) {
            if (nameText.Text.Equals("") || firstNameText.Text.Equals("") || phoneText.Text.Equals("") || emailText.Text.Equals("") || serviceCb.SelectedIndex == -1) {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                return;
            }
            Service staffService = (Service) serviceCb.SelectedItem;

            this.staff.SetNom(nameText.Text);
            this.staff.SetPrenom(firstNameText.Text);
            this.staff.SetTel(phoneText.Text);
            this.staff.SetEmail(emailText.Text);
            this.staff.SetService(staffService.Nom);
            this.staff.SetServiceId(staffService.IdService);

            controller.UpdateStaff(this.staff);

            this.Hide();
            this.callback?.Invoke(true);
        }

        private void handleCancel(object sender, EventArgs e) {
            this.Hide();
        }
    }
}