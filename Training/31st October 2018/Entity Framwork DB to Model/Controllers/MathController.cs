using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Example.Models;

namespace MVC_Example.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult Result(MathOperation mop)
        {
            mop.FindResult();
            MathOperation.ilist.Add(mop);
            return View("Index",MathOperation.ilist);
        }
    }
}