using AutoMapper;
using EvaluationApp.BL.ModelsBL;
using EvaluationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationApp.Web.App_Start
{
    public class AutoMapperProfileWeb : Profile
    {
        public AutoMapperProfileWeb()
        {
            CreateMap<UrlResponseStatBL, UrlResponseStatModel>().ReverseMap();
            CreateMap<WebsiteUrlBL, WebsiteUrlModel>().ReverseMap();
        }
    }
}