using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CompileResult
    {
        public bool IsBuildSuccess { get; set; }

        public List<CompilerError> Warnings { get; set; }

        public List<CompilerError> Errors { get; set; }
    }

}
