using AutoMapper;
using EvaluationApp.BL.ModelsBL;
using EvaluationApp.DAL.Models;
using EvaluationApp.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationApp.BL.Services
{
    public class UrlResponseStatService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<UrlResponseStat> _repository;

        public UrlResponseStatService(IMapper mapper, IGenericRepository<UrlResponseStat> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public int Create(UrlResponseStatBL modelBL)
        {
            var model = _mapper.Map<UrlResponseStat>(modelBL);
            return _repository.Create(model);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Edit(UrlResponseStatBL modelBL)
        {
            var model = _mapper.Map<UrlResponseStat>(modelBL);
            _repository.Edit(model);
        }

        public UrlResponseStatBL Get(int id)
        {
            return _mapper.Map<UrlResponseStatBL>(_repository.Get(id));
        }

        public IEnumerable<UrlResponseStatBL> Get(string include = "WebsiteUrl") // include - for loading nested objects data
        {
            return _mapper.Map<IEnumerable<UrlResponseStatBL>>(_repository.Get(include));
        }
    }
}
