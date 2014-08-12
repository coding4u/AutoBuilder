using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class LogModel
    {
        public string CurrentFolder { get; set; }

        public string DllPath { get; set; }

        public DateTime CompileTime { get; set; }

        public List<string> CSFileNames { get; set; }

        public CompileResult Results { get; set; }

    }
}
