using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1.Controllers
{
    public class ViDuController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Welcome(string name, int id = 1)
        //{
        //    ViewBag.Massage = "Xin chao" + name;
        //    ViewBag.NumTimes = id;
        //    return View();
        //}
        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Xin chào " + name;
            ViewBag.NumTimes = id;
            return View();
        }

    }
}