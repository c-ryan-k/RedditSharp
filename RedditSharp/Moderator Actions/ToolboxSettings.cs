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
        public ToolboxSettings(JObject json = null)
        {
            Header = HttpUtility.UrlDecode(json["header"].ToString());
            Footer = HttpUtility.UrlDecode(json["footer"].ToString());
            LogSub = json["logsub"].ToString();
            Reasons = new List<PostRemovalReason>();
            foreach (var reason in (JArray)json["reasons"])
            {
                var r = new PostRemovalReason((JObject)reason);

               Reasons.Add(r);
            }
            
        }
        public List<PostRemovalReason> Reasons { get; set; }
        public string LogSub { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
    }
    public class PostRemovalReason
    {
        public PostRemovalReason(JObject json = null)
        {
            ReasonText = HttpUtility.UrlDecode(json["text"].ToString());
            FlairText = json["flairText"].ToString();
            FlairCSS = json["flairCSS"].ToString();
            Title = json["title"].ToString();
        }
       
        public string ReasonText { get; set; }
        public string FlairText { get; set; }
        public string FlairCSS { get; set; }
        public string Title { get; set; }
    }
}
