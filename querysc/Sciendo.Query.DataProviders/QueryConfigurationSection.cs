using System.Configuration;

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

        [ConfigurationProperty("playerProcessIdentifier", DefaultValue = "", IsRequired = false)]
        public string PlayerProcessIdentifier
        {
            get
            {
                return (string)this["playerProcessIdentifier"];
            }
            set
            {
                this["playerProcessIdentifier"] = value;
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
        [ConfigurationProperty("pageSize", DefaultValue = 25, IsRequired = false)]
        public int PageSize
        {
            get
            {
                return (int)this["pageSize"];
            }
            set
            {
                this["pageSize"] = value;
            }
        }

    }
}