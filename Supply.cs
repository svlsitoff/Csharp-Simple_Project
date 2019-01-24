using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_project
{
    class Supply
    {
        Finance fin;
        public Supply()
        {
            fin = new Finance();
        }
        public int BringWood(int wood)
        {
            fin.OrderWood(wood);
            return wood;
        }
        public int SaleProduct(int table)
        {
            fin.SaleProduct(table);
            return table;
        }
    }
}
