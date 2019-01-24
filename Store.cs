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
        Supply sup;
        public int WoodNum=0;
        public int TableNum=0;
        string woodpath = @"ForStore\Wood.txt";
        string tablepath = @"ForStore\Tables.txt";
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
            sup = new Supply();
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
        public void OrderWood(int num)
        {
           WoodNum += sup.BringWood(num);
           WriteWoodData(WoodNum.ToString());
           
            
        }
        public void SaleTable(int num)
        {
            TableNum -= sup.SaleProduct(num);
            WriteTableData(TableNum.ToString());
        }

    }
        
    }

