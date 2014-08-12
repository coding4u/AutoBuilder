using AutoCompileService.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility;

namespace AutoCompileService
{
    public partial class AutoCompileService : ServiceBase
    {
        private readonly Object thisLock = new object();
        private bool stoped = false;

        public AutoCompileService()
        {
            InitializeComponent();
        }


        protected override void OnStart(string[] args)
        {

            string configXmlPath = (args == null || args.Length < 1) ? @"C:\config.xml" : args.First();

            if (!File.Exists(configXmlPath))
            {
                string message = string.Format("Config File: {0} not Found, Service can not start !", configXmlPath);
                Logger.WriteLog(message);
                throw new FileNotFoundException(message);
            }

            Logger.WriteLog("Service Started...");

            List<Utility.Configuration> configs = Utility.Configuration.GetAll(configXmlPath);

            DoWork(configs);
            
        }

        private void DoWork(List<Utility.Configuration> configs)
        {
            foreach (var config in configs)
            {
                new Thread(() =>
                {
                    do
                    {
                        try
                        {
                            var serviceSettings = ConfigurationManager.GetSection("ServiceSettingGroup/ServiceSetting");

                            var tmp = serviceSettings as ServiceSettings;


                            double d = 10;//the default interval is 10 minutes
                            double.TryParse(config.Interval, out d);
                            TimeSpan timeSpan = TimeSpan.FromMinutes(d);

                            Compile compile = new Compile(config.logPath);

                            compile.CompileExecutable(config.csPath, config.dllpath, config.buildType, config.resultPath);

                            lock (thisLock)
                            {
                                Monitor.Wait(thisLock, timeSpan);
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.WriteLog(ex.Message + "\n" + ex.StackTrace);
                        }

                    } while (!this.stoped);

                }).Start();
            }
        }

        protected override void OnStop()
        {
            this.stoped = true;
            Logger.WriteLog("Service Stoped...");

            lock (thisLock)
            {
                Monitor.Pulse(thisLock);
            }
        }

    }
}
