using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Simple_project
{
    class Finance
    {
       public string moneypath = @"ForMoney\Money.txt";
        public int money;
        public Finance()
        {
            if ((File.Exists(AppDomain.CurrentDomain.BaseDirectory + moneypath)))
            {
                using (StreamReader sr = new StreamReader(moneypath, Encoding.Default))
                {
                    bool succes = Int32.TryParse(sr.ReadLine(), out money);
                }
            }
            else
            {
                MessageBox.Show("Can't load file!");
            }
        }
        public void OrderWood(int woodcount)
        {
            money -= woodcount * 10;
            using (StreamWriter sr = new StreamWriter(moneypath, false, Encoding.Default))
            {
                sr.WriteLine(money);
            }
        }
        public void SaleProduct(int product)
        {
            money += product * 30;
            using (StreamWriter sr = new StreamWriter(moneypath, false, Encoding.Default))
            {
                sr.WriteLine(money);
            }
        }
    }
}
