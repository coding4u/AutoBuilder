using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompileService
{
    public class ServiceSettings
    {
        public string csPath { get; set; }

        public string dllPath { get; set; }

        public string logPath { get; set; }

        public string resultPath { get; set; }

        public string buildType { get; set; }

        public int interval { get; set; }

        public bool createLogIfNoError { get; set; }

        public bool showWarning { get; set; }


    }
}
