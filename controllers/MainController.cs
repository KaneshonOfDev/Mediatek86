using MediaTek86.dal;
using MediaTek86.models;

namespace MediaTek86.controllers {
    class MainController {
        public MainController () {}

        public void SetStaffs(BindingSource bdg) {
            StaffsService service = new StaffsService();
            List<Staff> staffs = service.GetAllStaffs();
            bdg.DataSource = staffs;
        }

        public void SetServices(BindingSource bdg) {
            ServicesService service = new ServicesService();
            List<Service> services = service.GetAllServices();
            bdg.DataSource = services;
        }

        public void SetMotifs(BindingSource bdg) {
            MotifsService service = new MotifsService();
            List<Motif> motifs = service.GetAllMotifs();
            bdg.DataSource = motifs;
        }

        public void SetAbsences(BindingSource bdg, Staff staff) {
            AbsencesService service = new AbsencesService();
            List<Absence> absences = service.GetAllAbsences(staff);
            bdg.DataSource = absences;
        }

        public void AddStaff(string name, string firstName, string phone, string email, Service staffService) {
            StaffsService service = new StaffsService();
            service.AddNewStaff(name, firstName, phone, email, staffService);
        }

        public void DeleteStaff(Staff staff) {
            StaffsService service = new StaffsService();
            service.DeleteStaff(staff);
        }

        public void UpdateStaff(Staff staff) {
            StaffsService service = new StaffsService();
            service.UpdateStaff(staff);
        }

        public void AddAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif) {
            AbsencesService service = new AbsencesService();
            service.AddNewAbsence(idpersonnel, datedebut, datefin, motif);
        }

        public void DeleteAbsence(Absence absence) {
            AbsencesService service = new AbsencesService();
            service.DeleteAbsence(absence);
        }

        public void UpdateAbsence(Absence absence, Absence newAbsence) {
            AbsencesService service = new AbsencesService();
            service.UpdateAbsence(absence, newAbsence);
        }
    }
}