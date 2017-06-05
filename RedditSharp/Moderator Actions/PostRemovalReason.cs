using Mono.Web;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditSharp
{
   public class PostRemovalReason
    {
        public PostRemovalReason(JObject json)
        {
            ReasonText = HttpUtility.UrlDecode(json["text"].ToString());
            Header = Header ?? "";
            Footer = Footer ?? "";
             FlairText = json["flairText"].ToString();
            FlairCSS = json["flairCSS"].ToString();
            Title = json["title"].ToString();
        }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string ReasonText { get; set; }
        public string FlairText { get; set; }
        public string FlairCSS { get; set; }
        public string Title { get; set; }
    }
}
