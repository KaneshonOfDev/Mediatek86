using MediaTek86.models;
using Serilog;

namespace MediaTek86.dal {
    class ServicesService : MService 
    {
        public ServicesService () {}

        public List<Service> GetAllServices() {
            string req = "select * from service order by nom";
            List<object[]> records = this.GetBddManager().ReqSelect(req, null);
            List<Service> services = new List<Service>();
            Log.Debug("Records.GetAllServices = {0}", records);
            if (records != null)
                {
                    foreach (Object[] record in records)
                    {
                        Service service = new Service((int)record[0], (string)record[1]);
                        services.Add(service);
                    }
                }
            Log.Debug("Services.GetAllServices = {0}", services);
            return services;
        }
    }
} 