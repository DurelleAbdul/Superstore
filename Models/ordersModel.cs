using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Superstore.Models
{
    public class ordersModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Row ID")]
        public int sRowID { get; set; }

        [BsonElement("Order ID")]
        public string sOrderId { get; set; }

        [BsonElement("Order Date")]
        public string sOrderDate { get; set; }

        [BsonElement("Ship Date")]
        public string sShipDate { get; set; }

        [BsonElement("Ship Mode")]
        public string sShipMode { get; set; }

        [BsonElement("Customer ID")]
        public string sCustomerID { get; set; }
        
        [BsonElement("Segment")]
        public string sSegment { get; set; }

        [BsonElement("City")]
        public string sCity { get; set; }

        [BsonElement("State")]
        public string sState { get; set; }

        [BsonElement("Country")]
        public string sCountry { get; set; }

        [BsonElement("Region")]
        public string sRegion { get; set; }

        [BsonElement("Market")]
        public string sMarket { get; set; }

        [BsonElement("Product ID")]
        public string sProductId { get; set; }

        [BsonElement("Category")]
        public string sCategory { get; set; }

        [BsonElement("Sub-Category")]
        public string sSubCategory { get; set; }

        [BsonElement("Product Name")]
        public string sProductName { get; set; }

        [BsonElement("Sales")]
        public string dSales { get; set; }

        [BsonElement("Quantity")]
        public int iQuantity { get; set; }

        [BsonElement("Profit")]
        public string dProfit { get; set; }

        [BsonElement("Shipping Cost")]
        public double dShippingCost { get; set; }

        [BsonElement("Order Priority")]
        public string sOrderPriority { get; set; }
    }
}