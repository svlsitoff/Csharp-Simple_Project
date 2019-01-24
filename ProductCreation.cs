using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_project
{
    class ProductCreation
    {
      
        Store store;
     
        public ProductCreation(int woodCount)
        {
            store = new Store();
            store.WoodNum -= woodCount;
            store.TableNum += woodCount * 2;
            store.WriteTableData(store.TableNum.ToString());
            store.WriteWoodData(store.WoodNum.ToString());
        }
    }
}
