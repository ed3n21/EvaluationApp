using AutoMapper;
using EvaluationApp.BL.Services;
using EvaluationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace EvaluationApp.Web.Controllers
{
    public class EvaluationController : Controller
    {
        private readonly WebsiteUrlService _websiteUrlService;
        private readonly UrlResponseStatService _urlResponseStatService;
        private readonly IMapper _mapper;

        public EvaluationController(WebsiteUrlService websiteUrlService, UrlResponseStatService urlResponseStatService, IMapper mapper)
        {
            _websiteUrlService = websiteUrlService;
            _urlResponseStatService = urlResponseStatService;
            _mapper = mapper;
        }

        public ActionResult Index(string site)
        {
            if (String.IsNullOrEmpty(site))
            {
                return View();
            }
            else
            {
                XmlTextReader doc = new XmlTextReader(site + "/sitemap.xml");
                List<string> urls = new List<string>();
                List<UrlResponseStatModel> urls = new List<UrlResponseStatModel>();
                while (doc.Read())
                {
                    if (doc.NodeType == XmlNodeType.Text)
                    {
                        UrlResponseStatModel = new UrlResponseStatModel { Date = DateTime.Now, WebsiteUrlId}
                        urls.Add(doc.Value.ToString());
                    }
                }
                ViewBag.Sitemap = urls;

                return View("Index", null, site);
            }
        }
    }
}