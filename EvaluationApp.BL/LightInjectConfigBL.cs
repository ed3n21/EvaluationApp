using EvaluationApp.DAL;
using EvaluationApp.DAL.Repository;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.BL
{
    class LightInjectConfigBL
    {
        public static ServiceContainer Configurate(ServiceContainer container)
        {
            container.Register<ApplicationDbContext>(new PerScopeLifetime());
            container.Register(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return container;
        }
    }
}
