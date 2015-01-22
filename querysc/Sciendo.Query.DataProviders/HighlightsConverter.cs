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
            var item = JObject.Load(reader);
            Dictionary<string, Highlighting> highlightings = new Dictionary<string, Highlighting>();
            foreach(var itemProperty in item.Properties())
            {
                var jjj = itemProperty;
            }
            var items = item.Properties();
            //var objectTypeId = item["ObjectTypeId"].Value<string>();
            //if (objectTypeId == "Player")
            //{
            //    var obj = item.ToObject<Player>();
            //    var objAction = ObjectActionsFactory.CreateObjectAction(objectTypeId);
            //    obj.AllowsTemplateAction = objAction.AllowsTemplateAction;
            //    obj.AllowsIndirectTemplateAction = objAction.AllowsIndirectTemplateAction;
            //    return obj;
            //}
            //else
            //{
            //    var obj = item.ToObject<Character>();
            //    var objAction = ObjectActionsFactory.CreateObjectAction(objectTypeId);
            //    obj.AllowsTemplateAction = objAction.AllowsTemplateAction;
            //    obj.AllowsIndirectTemplateAction = objAction.AllowsIndirectTemplateAction;
            //    return obj;
            //}
            return null;
        }
        public override bool CanConvert(Type objectType)
        {
//            return typeof(Character).IsAssignableFrom(objectType);
            if(objectType.Name.Contains("Dictionary"))
            {
                return true;
            }
            return false;
        }
    }
}
