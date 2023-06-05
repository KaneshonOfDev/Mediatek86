using MediaTek86.dal;
using MediaTek86.views;

namespace MediaTek86.controllers
{
    class AuthenticationController {
        private ConnectForm connectForm;

        public AuthenticationController(ConnectForm connectForm) {
            this.connectForm = connectForm;
        }

        public Boolean Login(string login, string password) {
            AuthenticationService service = new AuthenticationService();
            if(!service.Login(login, password)) return false;
            connectForm.Hide();
            StaffListForm form = new StaffListForm();
            form.ShowDialog();
            return true;
        }        

    }
}