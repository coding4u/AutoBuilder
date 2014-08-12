using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utility
{
    public class SerializeHelper
    {

        public static void SerializeToXML<T>(string outputFolder, T model, string fileName, bool addDateTimeSuffix)
        {
            try
            {
                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }
                string xmlFilePath;
                if (addDateTimeSuffix)
                {
                    xmlFilePath = Path.Combine(outputFolder, fileName + DateTime.Now.ToString("MMddhhmm") + ".xml");
                }
                else
                {
                    xmlFilePath = Path.Combine(outputFolder, fileName+".xml");
                }

                using (Stream writer = new FileStream(xmlFilePath, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, model);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\t" + ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }




        public static T DeserializeFromXML<T>(string xmlFilePath)
        {
            if (!File.Exists(xmlFilePath))
            {
                throw new FileNotFoundException(string.Format("{0} not Found!", xmlFilePath));
            }

            using (Stream reader = new FileStream(xmlFilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

        public static T DeserializeFromXML<T>(StreamReader xmlFilePath)
        {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(xmlFilePath);
            
        }
    }
}
