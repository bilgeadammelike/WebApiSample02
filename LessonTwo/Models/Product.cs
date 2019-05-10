using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonTwo.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }

    }
}