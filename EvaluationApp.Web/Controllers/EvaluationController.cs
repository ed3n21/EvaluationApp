using AutoMapper;
using EvaluationApp.BL.ModelsBL;
using EvaluationApp.BL.Services;
using EvaluationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
                // TODO: implement The Single Responsibility Principle
                WebsiteUrlModel website = new WebsiteUrlModel { Url = site, DateCreated = DateTime.Now };
                int websiteId = _websiteUrlService.Create(_mapper.Map<WebsiteUrlBL>(website));
                string urlString = site + "/sitemap.xml";

                List<UrlResponseStatModel> urls = new List<UrlResponseStatModel>();

                XmlTextReader reader = new XmlTextReader(urlString);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlString);

                        Stopwatch timer = new Stopwatch();
                        timer.Start();

                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        timer.Stop();

                        TimeSpan timeTaken = timer.Elapsed;

                        UrlResponseStatModel model = new UrlResponseStatModel
                        {
                            Date = DateTime.Now,
                            WebsiteUrlId = websiteId,
                            Url = reader.Value.ToString(),
                            ResponseTimeMs = (int)timeTaken.TotalMilliseconds
                        };
                        urls.Add(model);
                    }
                }
                ViewBag.Sitemap = urls;

                return View("Index", null, site);
            }
        }
    }
}