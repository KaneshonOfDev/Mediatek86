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
    }
}