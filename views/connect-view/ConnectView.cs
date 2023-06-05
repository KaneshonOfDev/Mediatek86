using MediaTek86.controllers;

namespace MediaTek86.views
{
    public partial class ConnectForm : Form
    {
        private AuthenticationController controller;

        public ConnectForm()
        {
            InitializeComponent();
            this.controller = new AuthenticationController(this);
        }

        public void handleLogin(object sender, EventArgs e) {
            if (loginText.Text.Equals("") && passwordText.Text.Equals("")) {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                return;
            }
             if (!controller.Login(loginText.Text, passwordText.Text)) {
                MessageBox.Show("Authentification incorrecte.", "Alerte");
                loginText.Text = "";
                passwordText.Text = "";
                loginText.Focus();
            }
        }
    }
}