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
    public class ProjectController : ApiController
    {
        private Service<Project> service;

        public ProjectController()
        {
            service = new Service<Project>();
        }

        public IEnumerable<ProjectVM> GetAll()
        {
            var service_result = service.GetAll();

            IEnumerable<ProjectVM> api_result = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectVM>>(service_result);

            return api_result;
        }

        public ProjectVM GetById(int id)
        {
            var service_result = service.GetById(id);

            ProjectVM api_result = Mapper.Map<Project, ProjectVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public ProjectVM Add(ProjectVM project)
        {
            Project service_result = service.Add(new Project
            {
                Project_Name = project.Project_Name,
                Project_Description = project.Project_Description,
                Project_Link = project.Project_Link,
            });
            service.Save();

            ProjectVM api_result = Mapper.Map<Project, ProjectVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public void Update(Project project)
        {
            service.Update(project);
            service.Save();
        }

        [HttpPost]
        public bool Delete(Project project)
        {
            return service.Delete(project);
        }
    }
}
