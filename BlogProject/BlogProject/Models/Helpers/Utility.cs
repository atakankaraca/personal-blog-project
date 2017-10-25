using BlogProject.Application.Model.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogTemp.Models.Helpers
{
    public class Utility
    {
        JsonFetcher fetcher = new JsonFetcher();

        //GET ARTICLE
        public IEnumerable<ArticleVM> getArticles()
        {
            var article_result = fetcher.GetJson(ApiStrings.domain, ApiStrings.article);
            IEnumerable<ArticleVM> article_root = JsonConvert.DeserializeObject<IEnumerable<ArticleVM>>(article_result, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            return article_root;
        }

        public ArticleVM getArticle(int? id)
        {
            var querystring = ApiStrings.article + id;

            var article_result = fetcher.GetJson(ApiStrings.domain, querystring);
            ArticleVM article_root = JsonConvert.DeserializeObject<ArticleVM>(article_result);

            return article_root;
        }

        //GET USER
        public IEnumerable<UserVM> getUsers()
        {
            var user_result = fetcher.GetJson(ApiStrings.domain, ApiStrings.user);
            IEnumerable<UserVM> user_root = JsonConvert.DeserializeObject<IEnumerable<UserVM>>(user_result, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            return user_root;
        }

        public UserVM getUser(int id)
        {
            var querystring = ApiStrings.user + id;

            var user_result = fetcher.GetJson(ApiStrings.domain, querystring);
            UserVM user_root = JsonConvert.DeserializeObject<UserVM>(user_result);

            return user_root;
        }

        //GET CATEGORY
        public IEnumerable<CategoryVM> getCategories()
        {
            var category_result = fetcher.GetJson(ApiStrings.domain, ApiStrings.category);
            IEnumerable<CategoryVM> category_root = JsonConvert.DeserializeObject<IEnumerable<CategoryVM>>(category_result, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            return category_root;
        }

        public CategoryVM getGategory(int id)
        {
            var querystring = ApiStrings.category + id;

            var category_result = fetcher.GetJson(ApiStrings.domain, ApiStrings.category);
            CategoryVM category_root = JsonConvert.DeserializeObject<CategoryVM>(category_result);

            return category_root;
        }

        //GET BIO
        public IEnumerable<BioVM> getBios()
        {
            var bio_result = fetcher.GetJson(ApiStrings.domain, ApiStrings.bio);
            IEnumerable<BioVM> bio_root = JsonConvert.DeserializeObject<IEnumerable<BioVM>>(bio_result, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore});

            return bio_root;
        }

        public BioVM getBio(int id)
        {
            var querystring = ApiStrings.bio + id;

            var bio_result = fetcher.GetJson(ApiStrings.domain, querystring);
            BioVM bio_root = JsonConvert.DeserializeObject<BioVM>(bio_result);

            return bio_root;
        }

        //GET PROJECT
        public IEnumerable<ProjectVM> getProjects()
        {
            var project_result = fetcher.GetJson(ApiStrings.domain, ApiStrings.project);
            IEnumerable<ProjectVM> project_root = JsonConvert.DeserializeObject<IEnumerable<ProjectVM>>(project_result, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            return project_root;
        }

        public ProjectVM getProject(int id)
        {
            var querystring = ApiStrings.project + id;

            var project_result = fetcher.GetJson(ApiStrings.domain, querystring);
            ProjectVM project_root = JsonConvert.DeserializeObject<ProjectVM>(project_result);

            return project_root;
        }
    }
}