using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogProject.Application;
using BlogProject.Application.Model.DTO;
using BlogTemp.Models;
using Newtonsoft.Json;
using BlogTemp.Models.Helpers;

namespace BlogTemp.Controllers
{
    public class HomeController : Controller
    {
        BlogAuth bAuth = new BlogAuth();
        JsonFetcher fetcher = new JsonFetcher();
        MultiModel model = new MultiModel();
        Utility utility = new Utility();

        IDictionary<string, string> cookie;

        public ActionResult Index()
        {
            bAuth.Login(out cookie);

            model.Articles = utility.getArticles();
            model.Categories = utility.getCategories();
            model.User = utility.getUser(1);
            model.Bio = utility.getBio(1);

            return View(model);
        }

        public ActionResult Categories(int? id)
        {
            model.Bio = utility.getBio(1);
            model.User = utility.getUser(1);
            model.Categories = utility.getCategories();
            model.Articles = utility.getArticles();

            ViewBag.ID = id;
            return View(model);
        }

        public ActionResult Articles(int? id)
        {
            model.Bio = utility.getBio(1);
            model.User = utility.getUser(1);
            model.Categories = utility.getCategories();
            model.Articles = utility.getArticles();

            if (id != null)
            {
                if (utility.getArticle(id) != null)
                    model.Article = utility.getArticle(id);
                else
                    return RedirectToAction("Index", "Home");

                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Tags(string id)
        {
            if(!string.IsNullOrEmpty(id))
            { 
            model.Bio = utility.getBio(1);
            model.User = utility.getUser(1);
            model.Categories = utility.getCategories();
            model.Articles = utility.getArticles();

            ViewBag.SearchString = id;
            return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}