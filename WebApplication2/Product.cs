using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Product: item //繼承item
    {
        public double Price
        {
            get; set;
        }

        public double Total_Sales(int volumn)
        {
            return volumn * Price;
        }
    }
}