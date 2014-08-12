using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompileService.Configuration
{
    public sealed class ServiceSettings : ConfigurationSection
    {

        [ConfigurationProperty("Setting", IsRequired = true)]
        public SettingCollection Setting
        {
            get { return (SettingCollection)base["Setting"]; }
        }

        //[ConfigurationProperty("PathSettings", IsRequired = false)]
        //public PathSettingElement PathSetting
        //{
        //    get { return (PathSettingElement)base["PathSettings"]; }
        //    set { base["PathSettings"] = value; }
        //}

    }
}
