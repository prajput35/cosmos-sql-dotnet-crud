using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace cosmos_sql
{
    class customer
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; } 

        [JsonProperty(PropertyName ="customerId")]
        public string customerId { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        
        [JsonProperty(PropertyName = "city")]
        public string city { get; set; }

        public customer(string p_id,string p_name,string p_city)
        {
            customerId = p_id;
            name = p_name;
            city=p_city;
        }
    }
}
