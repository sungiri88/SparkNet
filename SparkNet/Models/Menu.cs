using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SparkNet.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<Menu> List { get; set; }
    }    
}