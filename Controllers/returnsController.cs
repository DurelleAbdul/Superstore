using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Superstore.App_Start;
using Superstore.Models;

namespace Superstore.Controllers
{
    public class returnsController : Controller
    {
        // GET: returns
        public ActionResult Index()
        {
            return View();
        }
    }
}