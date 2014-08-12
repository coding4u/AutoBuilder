
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class ReflectionHelper
    {
        public static StreamReader GetResourceNames(string path)
        {
            StreamReader reader = null;
            try
            {
                MemoryStream memStream;
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    using (memStream = new MemoryStream())
                    {
                        int res;
                        byte[] b = new byte[4096];
                        while ((res = stream.Read(b, 0, b.Length)) > 0)
                        {
                            memStream.Write(b, 0, b.Length);
                        }
                    }
                }
                Assembly myAssembly = Assembly.Load(memStream.ToArray());

                var resouceNames = myAssembly.GetManifestResourceNames();
                if (resouceNames != null)
                {
                    foreach (var item in resouceNames)
                    {
                        if (item.EndsWith(".xml"))
                        {
                            reader = new StreamReader(myAssembly.GetManifestResourceStream(item));
                        }
                    }
                }

                List<string> s = GetDllNames();
                return reader;
            }
            catch (Exception)
            {
                return reader;
            }
        }

        public static List<string> GetDllNames()
        {

            List<Configuration> confogs = Configuration.GetAll(GlobalVariable.ConfigXml);
            List<string> results = new List<string>();
            if (confogs != null)
            {
                foreach (var item in confogs)
                {
                    //List<string> dllFiles = new FileHelper(item.resultPath, "*.dll").GetAllFiles();
                    //List<string> exeFiles = new FileHelper(item.resultPath, "*.exe").GetAllFiles();
                    //results.AddRange(dllFiles);
                    //results.AddRange(exeFiles);
                    results.Add(item.buildType);
                }
                
                results = RemoveRepeat.DeleteRepeat(results);
            }
            
            return results;
        }

        public static List<string> GetClassNames(string dllName)
        {
            List<string> results = new List<string>();
            StreamReader sr = GetResourceNames(dllName);
            if (sr != null)
            {
                CSFiles c = SerializeHelper.DeserializeFromXML<CSFiles>(sr);
                results = c.CSFileNames;
                results = RemoveRepeat.DeleteRepeat(results);
            }
            
            return results;
        }
    }
}
