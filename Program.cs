
using System.Drawing;

namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Ronit\\source\\repos\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchInventoryDetails fetchinventorydetails = new FetchInventoryDetails();

            Details data = fetchinventorydetails.Read(path);
            Console.WriteLine("Inventory Management");
            Console.WriteLine("Types of Rice details");


            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                int calculateprice = data.typesOfRice[i].price * data.typesOfRice[i].weight;

                Console.WriteLine("The price for " + data.typesOfRice[i].weight + " Kg is " + calculateprice);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Types of Wheat details");
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);
                int calculateprice = data.typesOfWheat[i].price * data.typesOfWheat[i].weight;

                Console.WriteLine("The price for " + data.typesOfWheat[i].weight + " Kg is " + calculateprice);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");




            Console.WriteLine("Types of Pulses details");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
                int calculateprice = data.typesOfPulses[i].price * data.typesOfPulses[i].weight;

                Console.WriteLine("The price for " + data.typesOfPulses[i].weight + " Kg is " + calculateprice);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");


        }
    }
}