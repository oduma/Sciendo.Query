﻿using Newtonsoft.Json;

namespace Sciendo.Query.DataProviders.Solr
{
    public class FacetFields
    {
        [JsonProperty("artist_f")]
        public object[] ArtistF { get; set; }
        [JsonProperty("extension_f")]
        public object[] ExtensionF { get; set; }
        [JsonProperty("letter_catalog_f")]
        public object[] LetterCatalogF { get; set; }
    }
}
