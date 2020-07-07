using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TransportCanada.Models
{
    public class Recall
    {
        public string recallNumber;
        public string manufactureName;
        public string makeName;
        public string modelName;
        public string recallYear;
        [JsonProperty (PropertyName = "MANUFACTURER_RECALL_NO_TXT")]
        public string MANUFACTURER_RECALL_NO_TXT;
    }
}
