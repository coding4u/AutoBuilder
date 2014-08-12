using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompileService.Configuration
{
    public sealed class SettingCollection : ConfigurationElementCollection
    {
        private IDictionary<string, string> settings;

        protected override ConfigurationElement CreateNewElement()
        {
            return new SettingElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            SettingElement ep = (SettingElement)element;

            return ep.Key;
        }

        protected override string ElementName
        {
            get
            {
                return base.ElementName;
            }
        }

        public IDictionary<string, string> Settings
        {
            get
            {
                if (settings == null)
                {
                    settings = new Dictionary<string, string>();
                    foreach (SettingElement e in this)
                    {
                        settings.Add(e.Key, e.Value);
                    }
                }
                return settings;
            }
        }

        public string this[string key]
        {
            get
            {
                string val;
                if (settings.TryGetValue(key, out val))
                {
                    return val;
                }
                else
                {
                    throw new ArgumentException("There is no " + key + "node");
                }
            }
        }

    }
}
