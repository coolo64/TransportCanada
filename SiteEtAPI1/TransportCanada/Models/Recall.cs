using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TransportCanada.Models
{
    public class Recall
    {
        [JsonProperty(PropertyName = "recallNumber")]
        public string recallNumber { get; set; }
        [JsonProperty(PropertyName = "manufactureName")]
        public string manufactureName { get; set; }
        [JsonProperty(PropertyName = "makeName")]
        public string makeName { get; set; }
        [JsonProperty(PropertyName = "modelName")]
        public string modelName { get; set; }
        [JsonProperty(PropertyName = "recallYear")]
        public string recallYear { get; set; }
        [JsonProperty (PropertyName = "MANUFACTURER_RECALL_NO_TXT")]
        public string MANUFACTURER_RECALL_NO_TXT { get; set; }
    }
}
