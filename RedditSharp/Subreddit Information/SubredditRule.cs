using Mono.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditSharp
{
    public class SubredditRule
    {
        public SubredditRule(JObject json)
        {
            Description = json["description"].ToString();
            Kind = json["kind"].ToString();
            ShortName = json["short_name"].ToString();
            ViolationReason = json["violation_reason"].ToString();
            int Pri = 0;
            Priority = int.TryParse(json["priority"].ToString(), out Pri) ? Pri : 0;
            DescriptionHTML = HttpUtility.HtmlDecode(json["description_html"].ToString());
        }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("violation_reason")]
        public string ViolationReason { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHTML { get; set; }


    }
}
