using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Superstore.Models;
using Superstore.App_Start;
using Superstore.ViewModels;
using MongoDB.Driver;

namespace Superstore.Controllers
{
    
    
    public class MainController : Controller
    {
        private MongoDBContext dBContext;
        private IMongoCollection<peopleModel> peopleCollection;
        private IMongoCollection<returnsModel> returnsCollection;
        private IMongoCollection<ordersModel> ordersCollection;
        public MainController()
        {
            dBContext = new MongoDBContext();
            peopleCollection = dBContext.database.GetCollection<peopleModel>("peopleView");
            returnsCollection = dBContext.database.GetCollection<returnsModel>("returnsView");
            ordersCollection = dBContext.database.GetCollection<ordersModel>("ordersView");

        }
        // GET: Main
        public ActionResult Index()
        {
            List<peopleModel> peopleList = peopleCollection.AsQueryable<peopleModel>().ToList();
            List<returnsModel> returnsList = returnsCollection.AsQueryable<returnsModel>().ToList();
            List<ordersModel> ordersList = ordersCollection.AsQueryable<ordersModel>().ToList();
            ViewModels.Admin admin = new ViewModels.Admin();


            int totalAfrica = (from x in peopleList.Where(x => x.Region.Contains("Africa")) select x.Person).Count();
            int totalEurope = (from x in peopleList.Where(x => x.Region.Contains("Europe")) select x.Person).Count();
            int totalAsia = (from x in peopleList.Where(x => x.Region.Contains("Asia")) select x.Person).Count();
            int totalUSA = (from x in peopleList.Where(x => x.Region.Contains("US")) select x.Person).Count();
            admin.Africa_count = totalAfrica;
            admin.Europe_count = totalEurope;
            admin.Asia_count = totalAsia;
            admin.USA_count = totalUSA;

           
            return View(admin);
        }
    }
}