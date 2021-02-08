using EvaluationApp.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.DAL.Models
{
    public class WebsiteUrl : IDataEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
