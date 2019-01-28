using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Simple_project
{
    class Store
    {
        string storepath = @"ForStore\Store.xml";
       // string connectionstrong =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владимир\Desktop\работа\C#\Simple_project\Simple_project\Database1.mdf;Integrated Security=True"
        public int WoodNum;
        public int TableNum;
       //public string woodpath = @"ForStore\Wood.txt";
       //public string tablepath = @"ForStore\Tables.txt";
        public Store()
        {
            if ((File.Exists(AppDomain.CurrentDomain.BaseDirectory + storepath)))
            {

                XDocument document = XDocument.Load(storepath);
                XElement element = document.Element("products");
                foreach (var node in element.Elements("product"))
                {
                    if (node.Attribute("name").Value == "wood")
                    {
                        WoodNum = Int32.Parse (node.Element("count").Value);
                    }
                    if (node.Attribute("name").Value == "table")
                    {
                        TableNum = Int32.Parse(node.Element("count").Value);
                    }
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
            XDocument document = XDocument.Load(storepath);
            XElement element = document.Element("products");
            foreach (var node in element.Elements("product"))
            {
                if (node.Attribute("name").Value == "wood")
                {
                   node.Element("count").Value = data;
                }
               
            }
            document.Save(storepath);

        }
        public void WriteTableData(string data)
        {
            XDocument document = XDocument.Load(storepath);
            XElement element = document.Element("products");
            foreach (var node in element.Elements("product"))
            {
                if (node.Attribute("name").Value == "table")
                {
                    node.Element("count").Value = data;
                }

            }
            document.Save(storepath);

        }
        public void OrderWood(int count)
        {
           WoodNum += count;
           WriteWoodData(WoodNum.ToString());
           
            
        }
        public void SaleTable(int num)
        {
            TableNum -= num;
            WriteTableData(TableNum.ToString());
        }

    }
        
    }

