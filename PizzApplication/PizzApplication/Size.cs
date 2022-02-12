using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApplication
{
    class Size
    {
        public string size { get; set; }
        public double AdditionalPrice { get; set; }
        public override string ToString()
        {
            return size;
        }
    }
}
