using Mono.Web;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditSharp
{
    public class ToolboxSettings
    {
        public ToolboxSettings()
        {
            header = "";
            footer = "";
            logsub = "";
            reasons = new List<PostRemovalReason>();

        }
        public ToolboxSettings(JObject json = null)
        {
            header = HttpUtility.UrlDecode(json["header"].ToString());
            footer = HttpUtility.UrlDecode(json["footer"].ToString());
            logsub = json["logsub"].ToString();
            reasons = new List<PostRemovalReason>();
            foreach (var reason in (JArray)json["reasons"])
            {
                var r = new PostRemovalReason((JObject)reason);

               reasons.Add(r);
            }
            
        }
        public List<PostRemovalReason> reasons { get; set; }
        public string logsub { get; set; }
        public string header { get; set; }
        public string footer { get; set; }
    }
    public class PostRemovalReason
    {
        public PostRemovalReason(JObject json = null)
        {
            text = HttpUtility.UrlDecode(json["text"].ToString());
            flairText = json["flairText"].ToString();
            flairCSS = json["flairCSS"].ToString();
            title = json["title"].ToString();
        }
       
        public string text { get; set; }
        public string flairText { get; set; }
        public string flairCSS { get; set; }
        public string title { get; set; }
    }
}
