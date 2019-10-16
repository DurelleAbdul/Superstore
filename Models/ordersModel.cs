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
        public string sRowID { get; set; }

        [BsonElement("Order ID")]
        public string sOrderId { get; set; }

        [BsonElement("Ship Date")]
        public DateTime dShipDate { get; set; }

        [BsonElement("Ship Mode")]
        public string sShipMode { get; set; }

        [BsonElement("Customer ID")]
        public string sCustomerID { get; set; }


        [BsonElement("Segment")]
        public string sSegment { get; set; }

        [BsonElement("Postal Code")]
        public string sPostalCode { get; set; }

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
        public double dSales { get; set; }

        [BsonElement("Quantity")]
        public int iQuantity { get; set; }

        [BsonElement("Discount")]
        public double dDiscount { get; set; }

        [BsonElement("Profit")]
        public double dProfit { get; set; }

        [BsonElement("Shipping Cost")]
        public double dShippingCost { get; set; }

        [BsonElement("Order Priority")]
        public string sOrderPriority { get; set; }
    }
}