using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApplication
{
    class Types
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Edge Edge { get; set; }
        public Size Size { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Amount {
            get
            {
                decimal amount = 0;
                amount += Price * (decimal)(Size.AdditionalPrice);
                amount += Edge.AdditionalPrice;
                return amount;
            }
        }
        public override string ToString()
        {
            return Name+Size;
        }
    }
}
