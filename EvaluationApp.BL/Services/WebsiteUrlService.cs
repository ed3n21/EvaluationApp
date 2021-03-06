﻿using AutoMapper;
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
    public class WebsiteUrlService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<WebsiteUrl> _repository;

        public WebsiteUrlService(IMapper mapper, IGenericRepository<WebsiteUrl> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public int Create(WebsiteUrlBL modelBL)
        {
            var model = _mapper.Map<WebsiteUrl>(modelBL);
            return _repository.Create(model);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Edit(WebsiteUrlBL modelBL)
        {
            var model = _mapper.Map<WebsiteUrl>(modelBL);
            _repository.Edit(model);
        }

        public WebsiteUrlBL Get(int id)
        {
            return _mapper.Map<WebsiteUrlBL>(_repository.Get(id));
        }

        public IEnumerable<WebsiteUrlBL> Get(string include = "") // include - for loading nested objects data
        {
            return _mapper.Map<IEnumerable<WebsiteUrlBL>>(_repository.Get(include));
        }
    }
}
