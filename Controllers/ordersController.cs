using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Superstore.App_Start;
using Superstore.Models;
using MongoDB.Driver;

namespace Superstore.Controllers
{
    public class ordersController : Controller
    {

        private MongoDBContext dBContext;
        private IMongoCollection<ordersModel> ordersCollection;
        // GET: orders

        public ordersController()
        {
            dBContext = new MongoDBContext();
            ordersCollection = dBContext.database.GetCollection<ordersModel>("ordersView");
        }

        public ActionResult Index()
        {
            List<ordersModel> myOrders = ordersCollection.AsQueryable<ordersModel>().ToList();
         

            return View(myOrders);
        }
    }
}