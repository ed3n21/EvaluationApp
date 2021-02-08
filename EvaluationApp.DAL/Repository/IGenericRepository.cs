using EvaluationApp.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.DAL.Repository
{
    public interface IGenericRepository<ModelDAL> where ModelDAL : class, IDataEntity
    {
        ModelDAL Get(int id);
        IEnumerable<ModelDAL> Get(string include = "");
        int Create(ModelDAL model);
        void Edit(ModelDAL model);
        void Delete(int id);
    }
}
