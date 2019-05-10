using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
 public   class ProductVM
    {

        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
