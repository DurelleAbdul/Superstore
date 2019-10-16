using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using Superstore.App_Start;
using Superstore.Models;

namespace Superstore.Controllers
{
    public class peopleController : Controller
    {

        private MongoDBContext dBContext;
        private IMongoCollection<peopleModel> peopleCollection;
        // GET: people
        public peopleController()
        {
            dBContext = new MongoDBContext();
            peopleCollection = dBContext.database.GetCollection<peopleModel>("peopleView");
        }
        public ActionResult Index()
        {
            List<peopleModel> myPeople = peopleCollection.AsQueryable<peopleModel>().ToList();

            return View(myPeople);
        }
    }
}