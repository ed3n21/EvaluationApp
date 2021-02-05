using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.DAL.Repository
{
    interface IGenericRepository<ModelDAL> where ModelDAL : class
    {
        ModelDAL Get(int id);
        IEnumerable<ModelDAL> Get(string include = "");
        void Create(ModelDAL model);
        void Edit(ModelDAL model);
        void Delete(int id);
    }
}
