using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.DAL.Repository
{
    public class GenericRepository<ModelDAL> : IDisposable, IGenericRepository<ModelDAL>
        where ModelDAL : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<ModelDAL> _dbSet;

        public GenericRepository()
        {
            _context = new ApplicationDbContext();
            _dbSet = _context.Set<ModelDAL>();
        }

        public void Create(ModelDAL model)
        {
            _dbSet.Add(model);
            _context.SaveChanges();
        }

        public void Edit(ModelDAL model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public ModelDAL Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<ModelDAL> Get(string include = "")
        {
            if (!String.IsNullOrEmpty(include))
                return _dbSet.Include(include).ToList();
            return _dbSet.ToList();
        }

        public void Delete(int id)
        {
            var model = _dbSet.Find(id);
            _dbSet.Remove(model);
            _context.SaveChanges();
        }




        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
