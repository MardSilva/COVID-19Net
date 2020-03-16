using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19NET
{
    class ClassePaises
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("cases")]
        public string Cases { get; set; }

        [JsonProperty("todayCases")]
        public string TodayCases { get; set; }

        [JsonProperty("deaths")]
        public string Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public string TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public string Recovered { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("critical")]
        public string Critical { get; set; }
    }
}
