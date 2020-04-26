using MySQL_Connect_to_ASP.NET_MVC.Models;
using MySQL_Connect_to_ASP.NET_MVC.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MySQL_Connect_to_ASP.NET_MVC.Controllers
{
    public class TestController : Controller
    {
        MV db = new MV();
        // GET: Test
        public ActionResult Index()
        {
            List<EMP> emp = db.GEtdb();
            ViewBag.emplist = emp;

            return View();
        }
    }
}