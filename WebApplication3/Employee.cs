using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Employee
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public List<string> Skill = new List<string>();
        
        public string get_info()
        {
            string r = "";
            if (Gender)
            {
                r = r + "Mr.";
            }
            else
            {
                r = r + "Miss ";
            }
            r = r + Name + "<br>";

            foreach (string i in Skill)
            {
                r = r + i + "<br>";
            }
            return r;
        }
    }
}