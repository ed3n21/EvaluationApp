using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvaluationApp.Web.Models
{
    public class UrlResponseStatModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 5)]
        public string Url { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public int ResponseTimeMs { get; set; }

        public int WebsiteUrlId { get; set; }
        public WebsiteUrlModel WebsiteUrl { get; set; }
    }
}