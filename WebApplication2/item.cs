using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class item
    {
        public string Name
        {
            get; set; 
        }
        public string ID
        {
            get; set;
        }

        public string Full_Name()
        {
            return ID + "_" + Name;
        }
    }
}