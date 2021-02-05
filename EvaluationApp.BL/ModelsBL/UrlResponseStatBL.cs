using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.BL.ModelsBL
{
    public class UrlResponseStatBL
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        public int ResponseTimeMs { get; set; }

        public int WebsiteUrlId { get; set; }
        public WebsiteUrlBL WebsiteUrl { get; set; }
    }
}
