using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Superstore.Models
{
    public class returnsModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Returned")]
        public string sReturned { get; set; }

        [BsonElement("Order ID")]
        public string sOrderID { get; set; }

        [BsonElement("Region")]
        public string sRegion { get; set; }


    }
}