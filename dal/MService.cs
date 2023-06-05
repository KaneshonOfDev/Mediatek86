using MediaTek86.bddmanager;

namespace MediaTek86.dal {
    class MService {
        private string connectorString = "Server=localhost;Username=root;Password=admin;Database=mediatek86;";
        private BddManager bddManager;

        public MService () {
            this.bddManager = BddManager.GetInstance(this.connectorString);
        }

        public string GetConnectorString {
            get => connectorString;
        }

        public BddManager GetBddManager() {
            if(this.bddManager == null) {
                this.bddManager = BddManager.GetInstance(this.connectorString);
            }
            return this.bddManager;
        }
    }
}