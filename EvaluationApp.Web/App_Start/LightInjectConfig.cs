using AutoMapper;
using EvaluationApp.BL;
using EvaluationApp.BL.Services;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace EvaluationApp.Web.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer(); 
            container = LightInjectConfigBL.Configurate(container);

            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new AutoMapperProfileWeb(), new AutoMapperProfileBL() }));

            container.Register(c => config.CreateMapper());


            container.Register<WebsiteUrlService>();
            container.Register<UrlResponseStatService>();

            container.EnableMvc();
        }
    }
}