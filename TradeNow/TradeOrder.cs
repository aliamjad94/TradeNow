using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.IO;
using TradeNowLibrary;

namespace TradeNow
{
    public partial class TradeOrder : Form
    {
        public class DeSerializeManager
        {
        public string OrderID { get; set; }
        public string Order { get; set; }
        public string Symbol { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Route { get; set; }
        public string OrderType { get; set; }
        public string Tif { get; set; }
        }
        public TradeOrder()
        {
            InitializeComponent();
        }

        private void TradeOrder_Load(object sender, EventArgs e)
        {
        }

        private void createOrder_Click(object sender, EventArgs e)
        {


            if (orderBox.Text != null && symbolBox.Text != null && quantityBox.Text != null && routeBox.Text != null && ordertypeBox.Text != null)
            {
                var data = new TraderClass
                {

                    Order = orderBox.Text,
                    Symbol = symbolBox.Text,
                    Quantity = quantityBox.Text,
                    Price = priceBox.Text,
                    Route = routeBox.Text,
                    OrderType = ordertypeBox.Text,
                    Tif = tifBox.Text
                };


            // ### Initialize the Path for saving data into the json file. ###

                string fileName = (@"C:\Users\ali.amjad\source\GitHub\repos\TradeNow\TradeNow\jsondata.json");
                var json = JsonConvert.DeserializeObject<List<TraderClass>>(File.ReadAllText(fileName));
                json.Add(data);


                //Console.WriteLine("+ \n + ");
                File.WriteAllText(fileName, JsonConvert.SerializeObject(json));
                Console.WriteLine(File.ReadAllText(fileName));
                MessageBox.Show("Order has been created!");

            //MessageBox.Show("Data Has Been Saved Successfully.");

            //        // Increasing index of OrderID //
            //        orderIDbox.TabIndex++;

            //        //using (StreamWriter file = File.CreateText(@"C:\Users\ali.amjad\Source\GitHub\repos\TradeNow\TradeNow\jsondata.json"))
            //        //using (JsonTextWriter r = new JsonTextWriter(file))
            //        //{
            //        //    JsonWriteData.WriteTo(r);
            //        //}


            //        // Writing Data into Json file //
            //    JObject JsonWriteData = new JObject(
            //                new JProperty("OrderID", orderIDbox.TabIndex.ToString()),
            //                new JProperty("Order", orderBox.Text),
            //                new JProperty("Symbol", symbolBox.Text),
            //                new JProperty("Quantity", quantityBox.Text),
            //                new JProperty("Price", priceBox.Text),
            //                new JProperty("Route", routeBox.Text),
            //                new JProperty("OrderType", ordertypeBox.Text),
            //                new JProperty("TiF", tifBox.Text));


            //        //File.WriteAllText(@"C:\Users\ali.amjad\Source\GitHub\repos\TradeNow\TradeNow\jsondata.json", JsonWriteData.ToString());
            //        //if (File.Exists(@"C:\Users\ali.amjad\Source\GitHub\repos\TradeNow\TradeNow\jsondata.json"))
            //        //{
            //        //    File.AppendAllTextAsync(@"C:\Users\ali.amjad\Source\GitHub\repos\TradeNow\TradeNow\jsondata.json", Environment.NewLine);
            //        //}

            //        


            //        // Reading Data from Json File //

            //        using (StreamReader r = new StreamReader(@"C:\Users\ztech.pk\source\repos\TradeApp\TradeNow\jsondata.json"))
            //        {
            //            string jsonFileContent = r.ReadToEnd();
            //            var result = JsonConvert.DeserializeObject<TraderClass>(jsonFileContent);
            //            var resultList = new List<TraderClass> { result };
                        dataGridView1.DataSource = json;



            }
            else
            {
             MessageBox.Show("Please Enter All Required attributes!");
            }
             
        }


        void textBox1_TextChanged_1(object sender, EventArgs e)
        {     
        }
        
        // Resetting values in case New Order Button is clicked //
        private void NewOrder_Click(object sender, EventArgs e)
        {
            //orderBox.ResetText();
            //symbolBox.ResetText();
            //quantityBox.ResetText()
            //priceBox.ResetText(),
            //routeBox.ResetText(),
            //ordertypeBox.ResetText(),
            //tifBox.ResetText()

        }

        // Log-out From TradeOrder form and Display Log-in again //

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Close();
            loginForm main = new loginForm();
            main.Show();
        }


    }
}
