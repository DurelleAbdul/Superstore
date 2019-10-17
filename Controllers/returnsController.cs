using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Superstore.App_Start;
using Superstore.Models;
using MongoDB.Driver;
using Superstore.App_Start;
using Superstore.Models;

namespace Superstore.Controllers
{
    public class returnsController : Controller
    {

        private MongoDBContext dBContext;
        private IMongoCollection<returnsModel> returnsCollection;
        // GET: people
        public returnsController()
        {
            dBContext = new MongoDBContext();
            returnsCollection = dBContext.database.GetCollection<returnsModel>("returnsView");
        }
        // GET: returns
        public ActionResult Index()
        {
            List<returnsModel> myReturns= returnsCollection.AsQueryable<returnsModel>().ToList();

            return View(myReturns);
        }
    }
}