using AutoMapper;
using BlogProject.Application.Model.DTO;
using BlogTemp.Data.Entity;
using BlogTemp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogProject.WebAPI.Controllers
{
    public class BioController : ApiController
    {
        private Service<Bio> service;

        public BioController()
        {
            service = new Service<Bio>();
        }

        public IEnumerable<BioVM> GetAll()
        {
            var service_result = service.GetAll();

            IEnumerable<BioVM> api_result = Mapper.Map<IEnumerable<Bio>, IEnumerable<BioVM>>(service_result);

            return api_result;
        }

        public BioVM GetById(int id)
        {
            var service_result = service.GetById(id);

            BioVM api_result = Mapper.Map<Bio, BioVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public BioVM Add(BioVM bio)
        {
            Bio service_result = service.Add(new Bio
            {
                 Bio1 = bio.Bio1,
                 User_ID = bio.User_ID
            });
            service.Save();

            BioVM api_result = Mapper.Map<Bio, BioVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public void Update(Bio bio)
        {
            service.Update(bio);
            service.Save();
        }

        [HttpPost]
        public bool Delete(Bio bio)
        {
            return service.Delete(bio);
        }
    }
}
