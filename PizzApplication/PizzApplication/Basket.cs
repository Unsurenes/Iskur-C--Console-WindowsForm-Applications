using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApplication
{
    class Basket
    {
        public Types types { get; set; }
        public int Number { get; set; }
        public decimal Total { get; set; }
        public override string ToString()
        { string order = "";
            order += types.Size.size + "Size, ";
            order += types.Name + ",";
            order += types.Edge.edge + "Edge, ";
            foreach(string item in types.Ingredients)
            {
                order += string.Format("{0},", item);
            }
            order = order.Remove(order.Length - 1, 1);
            order += string.Format("{0}*{1}={2}", Number, types.Amount, Number * types.Amount);
            return order;
        }
    }
}
