using AutoMapper;
using EvaluationApp.BL.ModelsBL;
using EvaluationApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.BL.Services
{
    public class WebsiteUrlService
    {
        private readonly IMapper _mapper;

        public WebsiteUrlService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public WebsiteUrl Map(WebsiteUrlBL model)
        {
            return _mapper.Map<WebsiteUrl>(model);
        }

        public WebsiteUrlBL Map(WebsiteUrl model)
        {
            return _mapper.Map<WebsiteUrlBL>(model);
        }

        public IEnumerable<WebsiteUrl> Map(IEnumerable<WebsiteUrlBL> models)
        {
            return _mapper.Map<IEnumerable<WebsiteUrl>>(models);
        }

        public IEnumerable<WebsiteUrlBL> Map(IEnumerable<WebsiteUrl> models)
        {
            return _mapper.Map<IEnumerable<WebsiteUrlBL>>(models);
        }
    }
}
