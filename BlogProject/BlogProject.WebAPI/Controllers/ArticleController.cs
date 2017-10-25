using AutoMapper;
using BlogProject.Application.Model.DTO;
using BlogTemp.Data.Entity;
using BlogTemp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogProject.WebAPI.Controllers
{
    public class ArticleController : ApiController
    {
        private Service<Article> service;

        public ArticleController()
        {
            service = new Service<Article>();
        }
        
        public IEnumerable<ArticleVM> GetAll()
        {
            var service_result = service.GetAll();

            IEnumerable<ArticleVM> api_result = Mapper.Map<IEnumerable<Article>, IEnumerable<ArticleVM>>(service_result);

            return api_result;
        }

        public ArticleVM GetById(int id)
        {
            var service_result = service.GetById(id);

            ArticleVM api_result = Mapper.Map<Article, ArticleVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public ArticleVM Add(ArticleVM article)
        {
           Article service_result = service.Add(new Article
            {
                Author_ID = article.Author_ID,
                Category_ID = article.Category_ID,
                Created_Date = DateTime.Now,
                Is_Deleted = false,
                Post_Content = article.Post_Content,
                Tags = article.Tags,
                Title = article.Title,
                ViewCount = 0
            });
            service.Save();

            ArticleVM api_result = Mapper.Map<Article, ArticleVM>(service_result);

            return api_result;
        }

        [HttpPost]
        public void Update (Article article)
        {
            service.Update(article);
            service.Save();
        }

        [HttpPost]
        public bool Delete (Article article)
        {
            return service.Delete(article);
        }

        //public IQueryable<Article> GetAll(Expression<Func<Article, bool>> predicate)
        //{
        //    var query = service.GetAll(predicate);
        //    return query;
        //}
    }
}
