using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Worker
{
    class BufWorker
    {
        [JsonPropertyName("FName")]
        public string FName
        {
            get;set;
        }

        [JsonPropertyName("SName")]
        public string SName
        {
            get; set;
        }
        [JsonPropertyName("CType")]
        public string CType
        {
            get;set;
        }
    }
}
