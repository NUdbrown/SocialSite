using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialSite.Models;
using System.IO;

namespace SocialSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult ProfileThemeTwo()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            var gal = new ImageDisplayMod()
            {
                Images = Directory.EnumerateFiles(Server.MapPath("~/Images/GalleryImgs"))
                .Select(fn => "~/Images/GalleryImgs/" + Path.GetFileName(fn))
            };
            return View(gal);
        }
    }
}