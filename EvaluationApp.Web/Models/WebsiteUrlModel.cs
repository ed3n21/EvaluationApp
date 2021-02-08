using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvaluationApp.Web.Models
{
    public class WebsiteUrlModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 5)]
        public string Url { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
}