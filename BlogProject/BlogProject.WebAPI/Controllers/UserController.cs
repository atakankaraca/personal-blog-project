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
    public class UserController : ApiController
    {
        private Service<User> service;

        public UserController()
        {
            service = new Service<User>();
        }

        public IEnumerable<UserVM> GetAll()
        {
            var service_result = service.GetAll();

            IEnumerable<UserVM> api_result = Mapper.Map<IEnumerable<User>, IEnumerable<UserVM>>(service_result);

            return api_result;
        }

        public UserVM GetById(int id)
        {
            var service_result = service.GetById(id);

            UserVM api_result = Mapper.Map<User, UserVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public UserVM Add(UserVM user)
        {
            User service_result = service.Add(new User
            {
                ID = user.ID,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Username = user.Username,
                Mail = user.Mail,
                Password = user.Password              
            });
            service.Save();

            UserVM api_result = Mapper.Map<User, UserVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public void Update(User user)
        {
            service.Update(user);
            service.Save();
        }

        [HttpPost]
        public bool Delete(User user)
        {
            return service.Delete(user);
        }
    }
}
