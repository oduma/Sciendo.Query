using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Sciendo.Query.DataProviders
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

        [ConfigurationProperty("currentPlayerProcess", DefaultValue = "mockProcess", IsRequired = true)]
        public string CurrentPlayerProcess
        {
            get
            {
                return (string)this["currentPlayerProcess"];
            }
            set
            {
                this["currentPlayerProcess"] = value;
            }
        }

        [ConfigurationProperty("solrConnectionString", DefaultValue = "", IsRequired = false)]
        public string SolrConnectionString
        {
            get
            {
                return (string)this["solrConnectionString"];
            }
            set
            {
                this["solrConnectionString"] = value;
            }
        }

    }
}