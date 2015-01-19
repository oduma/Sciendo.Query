using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Sciendo.Query
{
    public class QueryConfigurationSection:ConfigurationSection
    {
        [ConfigurationProperty("currentDataProvider", DefaultValue = "mockResultsProvider", IsRequired = true)]
        public string CurrentDataProvider
        {
            get
            {
                return (string)this["currentDataProvider"];
            }
            set
            {
                this["currentDataProvider"] = value;
            }
        }

    }
}