using EvaluationApp.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.DAL.Models
{
    public class UrlResponseStat : IDataEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        public int ResponseTimeMs { get; set; }

        public int WebsiteUrlId { get; set; }
        public WebsiteUrl WebsiteUrl { get; set; }
    }
}
