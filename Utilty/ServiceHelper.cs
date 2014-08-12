using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class ServiceHelper
    {
        public static ServiceController FindService(string serviceName)
        {
            var query = from svc in ServiceController.GetServices()
                        where (svc.ServiceName == serviceName)
                        select svc;
            return query.FirstOrDefault();
        }

        public static bool StartAutoCompileService(string[] args, string name)
        {
            bool isSuccess = false;
            ServiceController sc = FindService(name);

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                sc.Start(args);
                isSuccess = true;
            }
            return isSuccess;
        }

        public static bool StopAutoCompileService(string name)
        {
            bool isSuccess = false;
            ServiceController sc = FindService(name);

            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
                isSuccess = true;
            }
            return isSuccess;
        }
    }
}
