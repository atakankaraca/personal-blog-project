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
    public class CategoryController : ApiController
    {
        private Service<Category> service;

        public CategoryController()
        {
            service = new Service<Category>();
        }

        public IEnumerable<CategoryVM> GetAll()
        {
            var service_result = service.GetAll();

            IEnumerable<CategoryVM> api_result = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryVM>>(service_result);

            return api_result;
        }

        public CategoryVM GetById(int id)
        {
            var service_result = service.GetById(id);

            CategoryVM api_result = Mapper.Map<Category, CategoryVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public CategoryVM Add(CategoryVM category)
        {
            Category service_result = service.Add(new Category
            {
                Category_Name = category.Category_Name
            });
            service.Save();

            CategoryVM api_result = Mapper.Map<Category, CategoryVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public void Update(Category category)
        {
            service.Update(category);
            service.Save();
        }

        [HttpPost]
        public bool Delete(Category category)
        {
            return service.Delete(category);
        }
    }
}
