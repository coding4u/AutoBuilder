using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class FileHelper
    {
        private string folder;
        private string searchPattern;

        public FileHelper(string folder, string searchPattern)
        {
            this.folder = folder;
            this.searchPattern = searchPattern;
        }

        public List<string> GetAllFiles()
        {
            return Directory.GetFiles(folder, searchPattern, SearchOption.AllDirectories).ToList();

        }

        public List<string> GetAllFileNames()
        {
           var fileInfos = new DirectoryInfo(folder).GetFiles(searchPattern, SearchOption.AllDirectories);
           return fileInfos.AsParallel().Select(fi=>fi.Name).ToList();

        }


        public static FileInfo GetLastFile(Configuration c)
        {
            DirectoryInfo directory = new DirectoryInfo(c.logPath);
            string str = c.buildType.Replace(".", "");
            FileInfo[] fileInfoArray = directory.GetFiles();
            List<FileInfo> f = new List<FileInfo>();
            if (fileInfoArray.Length > 0)
            {
                foreach (var item in fileInfoArray)
                {
                    if (item.Extension == ".xml" && item.Name.Contains(str))
                    {
                        f.Add(item);
                        string s = item.LastWriteTime.ToString();
                    }
                }

                var lastTime = f.Select(d => d.LastWriteTime).ToList().Max();
                var lastFile = f.Where(d => d.LastWriteTime == lastTime).SingleOrDefault();
                return lastFile;
            }
            else
            {
                return null;
            }
            
        }
    }
}
