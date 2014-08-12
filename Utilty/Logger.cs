using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Logger
    {
        public static readonly string ServiceLogPath=@"C:\AutoCompileService";

        /// <summary>
        /// Write to a log 
        /// </summary>
        /// <param name="message">Information be writed</param>
        public static void WriteLog(string message)
        {
            if (!Directory.Exists(ServiceLogPath))
            {
                Directory.CreateDirectory(ServiceLogPath);
            }

            using (FileStream fs = new FileStream(
                System.IO.Path.Combine(ServiceLogPath, "RunningStatus.log"),
                FileMode.OpenOrCreate,
                FileAccess.Write))
            {

                using (StreamWriter writer = new StreamWriter(fs))
                {

                    writer.BaseStream.Seek(0, SeekOrigin.End);
                    writer.WriteLine(DateTime.Now.ToString() + ":\t" + message);
                    writer.Flush();
                }
            }
        }
    }
}
