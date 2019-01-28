using System;
using Microsoft.VisualBasic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Simple_project
{
    public partial class Form1 : Form
    {   
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
            int woods = Int32.Parse(dataWood.Trim());
            fin.OrderWood(woods);
            store.OrderWood(woods);

            textBox1.Text = store.WoodNum.ToString(); ;
            
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
            int tables = Int32.Parse(datatable.Trim());
            store.SaleTable(tables);
            fin.SaleProduct(tables);
           
                textBox2.Text = store.TableNum.ToString();
            
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
            
                textBox1.Text = store.WoodNum.ToString();
            
           
                textBox2.Text = store.TableNum.ToString();
            
        }
    }
}
