using System;
using Microsoft.VisualBasic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Simple_project
{
    public partial class Form1 : Form
    {
        string moneypath = @"ForMoney\Money.txt";
        string woodpath = @"ForStore\Wood.txt";
        string tablepath = @"ForStore\Tables.txt";
        Store store;
        Finance fin;
        Supply sup;
        
       
        public Form1()
        {
            InitializeComponent();
            store = new Store();
            fin = new Finance();
            sup = new Supply();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            textBox1.Text = store.WoodNum.ToString();
            textBox2.Text = store.TableNum.ToString();
            textBox3.Text = fin.money.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
               string data =  Interaction.InputBox("Input How much wood do you want", "Order", "0");
            int woods = 0;
            Int32.TryParse(data, out woods);
            store.OrderWood(woods);   
                 textBox1.Text = store.WoodNum.ToString();
                using (StreamReader sr = new StreamReader(moneypath, Encoding.Default))
                {
                    textBox3.Text = sr.ReadLine();
                 }
            }
           
           
          
           
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            string data = Interaction.InputBox("Input How much tables do you want to sell", "Order", "0");
            int tables = 0;
            Int32.TryParse(data,out tables);

            store.SaleTable(tables);           
            textBox2.Text = store.TableNum.ToString();
            using (StreamReader sr = new StreamReader(moneypath, Encoding.Default))
            {
                textBox3.Text = sr.ReadLine();
            }

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProductCreation pc = new ProductCreation(10);
            using (StreamReader sr = new StreamReader(woodpath, Encoding.Default))
            {
                textBox1.Text = sr.ReadLine();
            }
            using (StreamReader sr = new StreamReader(tablepath, Encoding.Default))
            {
                textBox2.Text = sr.ReadLine();
            }
        }
    }
}
