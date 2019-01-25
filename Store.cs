using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Simple_project
{
    class Store
    {

        public int WoodNum;
        public int TableNum;
       public string woodpath = @"ForStore\Wood.txt";
       public string tablepath = @"ForStore\Tables.txt";
        public Store()
        {
            //получаем данные о дереве и столах из текстовых файлов
            
            if ((File.Exists(AppDomain.CurrentDomain.BaseDirectory + woodpath)) && File.Exists(AppDomain.CurrentDomain.BaseDirectory + tablepath))
            {
                using (StreamReader sr = new StreamReader(woodpath, Encoding.Default))
                {

                    bool succes = Int32.TryParse(sr.ReadLine(), out WoodNum);
                    
                 
                }
                using (StreamReader sr = new StreamReader(tablepath, Encoding.Default))
                {

                    bool succes = Int32.TryParse(sr.ReadLine(), out TableNum);
                
                }
            }
            else
            {
                MessageBox.Show("Нет файлов");
            }
          
        }

        //определяем два метода которые будут записывать данные в текстовые файлы
            public void WriteWoodData(string data)
            {
             using (StreamWriter sr = new StreamWriter(woodpath,false, Encoding.Default))
                {

                sr.WriteLine(data);
                }
            }
        public void WriteTableData(string data)
        {
            using (StreamWriter sr = new StreamWriter(tablepath, false, Encoding.Default))
            {

                sr.WriteLine(data);
            }
        }
        public void OrderWood(int count)
        {
       //     sup.BringWood(count);
           WoodNum += count;
           WriteWoodData(WoodNum.ToString());
           
            
        }
        public void SaleTable(int num)
        {
          //  sup.SaleProduct(num);
            TableNum -= num;
            WriteTableData(TableNum.ToString());
        }

    }
        
    }

