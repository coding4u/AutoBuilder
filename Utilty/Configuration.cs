using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Utility
{
    public class Configuration
    {
        public string csPath { get; set; }
        public string dllpath { get; set; }
        public string logPath { get; set; }
        public string resultPath { get; set; }
        public string buildType { get; set; }
        public string Interval { get; set; }


        public void CreateDocument(string path)
        {
            if (!File.Exists(path))
            {
                XDocument xdoc = new XDocument(new XDeclaration("1.0", "Default", "yes"),
                                           new XElement("Root"));
                xdoc.Save(path);
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool AddConfiguration(string path)
        {
            if (!File.Exists(path))
            {
                XDocument xdoc = new XDocument(new XDeclaration("1.0", "Default", "yes"),
                                           new XElement("Root"));
                xdoc.Save(path);
            }

            XElement db = new XElement("Configuration",

                   new XAttribute("buildType", buildType),

                   new XElement("dllpath", new XAttribute("value", dllpath)),

                   new XElement("logPath", new XAttribute("value", logPath)),

                   new XElement("resultPath", new XAttribute("value", resultPath)),

                   new XElement("csPath", new XAttribute("value", csPath)),

                   new XElement("Interval", new XAttribute("value", Interval))

                   );

            try
            {
                XDocument doc = XDocument.Load(path);
                doc.Element("Root").Add(db);
                doc.Save(path);
                return true;
            }

            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Remove(string id)
        {
            XDocument doc = new XDocument();
            doc = XDocument.Load(GlobalVariable.ConfigXml);

            XElement xe = (from db in doc.Element("Root").Elements("Configuration") where db.Attribute("buildType").Value == id select db).Single() as XElement;

            try
            {
                xe.Remove();
                doc.Save(GlobalVariable.ConfigXml);
                return true;
            }

            catch
            {
                return false;
            }
        }


        /// <summary>
        /// select
        /// </summary>
        /// <returns></returns>
        public static List<Configuration> GetAll(string path)
        {
            if (File.Exists(path))
            {
            XDocument doc = XDocument.Load(path);

            List<Configuration> dbs = (from db in doc.Element("Root").Elements("Configuration")

                                       select new Configuration
                                       {
                                           buildType = db.Attribute("buildType").Value.ToString(),

                                           dllpath = db.Element("dllpath").Attribute("value").Value.ToString(),

                                           resultPath = db.Element("resultPath").Attribute("value").Value.ToString(),

                                           logPath = db.Element("logPath").Attribute("value").Value.ToString(),

                                           csPath = db.Element("csPath").Attribute("value").Value.ToString(),

                                           Interval = db.Element("Interval").Attribute("value").Value.ToString()
                                       }).ToList();
            return dbs;
            }
            else
            {
                return null;
            }

        }


        public static Configuration GetConfig(string path, string id)
        {
            //XDocument doc = XDocument.Load(path);
            try
            {
                XDocument doc = XDocument.Load(path);
                XElement xe = (from db in doc.Element("Root").Elements("Configuration") where db.Attribute("buildType").Value == id select db).Single() as XElement;
                Configuration config = new Configuration
                {
                    buildType = xe.Attribute("buildType").Value.ToString(),
                    Interval = xe.Element("Interval").Attribute("value").Value,
                    dllpath = xe.Element("dllpath").Attribute("value").Value,
                    resultPath = xe.Element("resultPath").Attribute("value").Value,
                    logPath = xe.Element("logPath").Attribute("value").Value,
                    csPath = xe.Element("csPath").Attribute("value").Value
                };
                return config;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        ///update
        /// </summary>
        /// <returns></returns>
        public static bool Modify(string id, Configuration c)
        {
            XDocument doc = new XDocument();
            doc = XDocument.Load(GlobalVariable.ConfigXml);

            XElement xe = (from db in doc.Element("Root").Elements("Configuration") where db.Attribute("buildType").Value == id select db).Single() as XElement;

            try
            {
                xe.Attribute("buildType").Value = c.buildType;

                xe.Element("Interval").Attribute("value").Value = c.Interval.ToString();

                xe.Element("dllpath").Attribute("value").Value = c.dllpath;

                xe.Element("resultPath").Attribute("value").Value = c.resultPath;

                xe.Element("logPath").Attribute("value").Value = c.logPath;

                xe.Element("csPath").Attribute("value").Value = c.csPath;

                doc.Save(GlobalVariable.ConfigXml);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
