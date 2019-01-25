using System;
using Microsoft.VisualBasic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Simple_project
{
    public partial class Form1 : Form
    {
        //string moneypath = @"ForMoney\Money.txt";
        //string woodpath = @"ForStore\Wood.txt";
        //string tablepath = @"ForStore\Tables.txt";
        //Store store;
        //Finance fin;
        //Supply sup;
        
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var store = new Store();
            var fin = new Finance();
            textBox1.Text = store.WoodNum.ToString();
            textBox2.Text = store.TableNum.ToString();
            textBox3.Text = fin.money.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var store = new Store();
            var fin = new Finance();
            string dataWood =  Interaction.InputBox("Input How much wood do you want", "Order", "0");
            MessageBox.Show(dataWood);
            int woods = Int32.Parse(dataWood.Trim());
            MessageBox.Show(woods.ToString());
            fin.OrderWood(woods);
            store.OrderWood(woods);
            using (StreamReader sr = new StreamReader(store.woodpath, Encoding.Default))
            {
                textBox1.Text = sr.ReadLine();
            }

            using (StreamReader sr = new StreamReader(fin.moneypath, Encoding.Default))
                {
                    textBox3.Text = sr.ReadLine();
                 }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var store = new Store();
            var fin = new Finance();
            string datatable = Interaction.InputBox("Input How much tables do you want to sell", "Order", "0");
            MessageBox.Show(datatable);
            int tables = Int32.Parse(datatable.Trim());
            MessageBox.Show(tables.ToString());

            store.SaleTable(tables);
            fin.SaleProduct(tables);
            using (StreamReader sr = new StreamReader(store.tablepath, Encoding.Default))
            {
                textBox2.Text = sr.ReadLine();
            }
            using (StreamReader sr = new StreamReader(fin.moneypath, Encoding.Default))
            {
                textBox3.Text = sr.ReadLine();
            }

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            var store = new Store();
            var fin = new Finance();
            ProductCreation pc = new ProductCreation(10);
            using (StreamReader sr = new StreamReader(store.woodpath, Encoding.Default))
            {
                textBox1.Text = sr.ReadLine();
            }
            using (StreamReader sr = new StreamReader(store.tablepath, Encoding.Default))
            {
                textBox2.Text = sr.ReadLine();
            }
        }
    }
}
