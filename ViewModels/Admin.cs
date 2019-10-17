using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superstore.ViewModels
{
    public class Admin
    {
        public int Africa_count { get; set; }
        public int Europe_count { get; set; }
        public int USA_count { get; set; }
        public int Asia_count { get; set; }

        //orders
        public int product_count { get; set; }
        public int regionOfProduct_count { get; set; }
        public int France_count { get; set; }
        public int cities_count { get; set; }
        public int State_count { get; set; }
        public int SubCategories_count { get; set; }
    }
}