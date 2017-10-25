using BlogProject.Application.Model.DTO;
using BlogTemp.Models;
using BlogTemp.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogTemp.Controllers
{
    public class AboutController : Controller
    {
        BlogAuth bAuth = new BlogAuth();
        JsonFetcher fetcher = new JsonFetcher();
        MultiModel model = new MultiModel();
        Utility utility = new Utility();

        IDictionary<string, string> cookie;

        // GET: About
        public ActionResult Index()
        {
            bAuth.Login(out cookie);

            model.User = utility.getUser(1);
            model.Bio = utility.getBio(1);
            model.Projects = utility.getProjects().Where(x=>x.User_ID == 1);

            return View(model);
        }
    }
}