using AutoMapper;
using EvaluationApp.BL.ModelsBL;
using EvaluationApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.BL
{
    class AutoMapperProfileBL : Profile
    {
        public AutoMapperProfileBL()
        {
            CreateMap<WebsiteUrl, WebsiteUrlBL>().ReverseMap();
            CreateMap<UrlResponseStat, UrlResponseStatBL>().ReverseMap();
        }
    }
}
