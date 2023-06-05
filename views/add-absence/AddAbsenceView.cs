using MediaTek86.controllers;

namespace MediaTek86.views
{
    public partial class AddAbsenceForm : Form
    {
        private MainController controller;
        public BindingSource bdgMotifs = new BindingSource();
        
        public AddAbsenceForm()
        {
            InitializeComponent();
            this.controller = new MainController();
            this.fillMotifs();
        }

        private void fillMotifs() {
            this.controller.SetMotifs(bdgMotifs);
            motifCb.DataSource = bdgMotifs;
            if (motifCb.Items.Count > 0)
            {
                motifCb.SelectedIndex = 0;
            }
        }
    }
}