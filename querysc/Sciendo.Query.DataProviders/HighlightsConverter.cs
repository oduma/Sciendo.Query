using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sciendo.Query.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.DataProviders
{
    public class HighlightsConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType.GenericTypeArguments[1].Name == "Highlighting")
                return ReadHighlighting(reader);
            else
                return ReadFacetFields(reader);
        }

        private static object ReadFacetFields(JsonReader reader)
        {
            return null;
        }

        private static object ReadHighlighting(JsonReader reader)
        {
            var item = JObject.Load(reader);
            Dictionary<string, Highlighting> highlightings = new Dictionary<string, Highlighting>();
            foreach (var itemProperty in item.Properties())
            {
                var highlighting = JsonConvert.DeserializeObject<Highlighting>(itemProperty.Value.ToString());
                highlightings.Add(itemProperty.Name, highlighting);
            }
            return highlightings;
        }
        public override bool CanConvert(Type objectType)
        {
            if(objectType.Name.Contains("Dictionary"))
            {
                return true;
            }
            return false;
        }
    }
}
