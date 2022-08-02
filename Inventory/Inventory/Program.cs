using System;
using System.Xml.Schema;

namespace Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Melaniia Frolova         Inventory Report        Sept 29, 2020");
            
            const int hammersnumber = 1000;              
            const int hammers = 24;
            const double hammersprofit = 113.76d;


            Console.Write("Item number:{0}", hammersnumber);
            Console.WriteLine("{0,38}","Description: Hammers");
            //I have a question about the space between "Description" and "Item number" here. 
            Console.WriteLine("Quantity:{0}", hammers);
            Console.WriteLine("Profit:{0:c}", hammersprofit);
            Console.WriteLine();

            const int sawsnumber = 1000;
            const int saws = 24;
            const double sawsprofit = 70.00d;


            Console.Write("Item number:{0}", sawsnumber);
            Console.WriteLine("{0,35}", "Description: Saws");
            Console.WriteLine("Quantity:{0}", saws);
            Console.WriteLine("Profit:{0:c}", sawsprofit);
            Console.WriteLine();

            const int screwsnumber = 1000;
            const int screws = 24;
            const double screwsprofit = 244.08d;


            Console.Write("Item number:{0}", screwsnumber);
            Console.WriteLine("{0,43}", "Description: Screwdrivers");
            Console.WriteLine("Quantity:{0}", screws);
            Console.WriteLine("Profit:{0:c}", screwsprofit);
            Console.WriteLine();

            const double unitcost1 = 4.75d;
            const double unitcost2 = 17.50d;
            const double unitcost3 = 8.92d;
            const double sellingprice1 = 9.49;
            const double sellingprice2 = 22.50;
            const double sellingprice3 = 15.70;

            double totalcost1 = hammers * unitcost1;
            double totalcost2 = saws * unitcost2;
            double totalcost3 = screws * unitcost3;
            double totalcost = totalcost1 + totalcost2 + totalcost3;

            double totalincome1 = hammers * sellingprice1;
            double totalincome2 = saws * sellingprice2;
            double totalincome3 = screws * sellingprice3;
            double totalincome = totalincome1 + totalincome2 + totalincome3;

            double profit1 = totalincome1 - totalcost1;
            double profit2 = totalincome2 - totalcost2;
            double profit3 = totalincome3 - totalcost3;
            double profit = totalincome - totalcost;

            Console.WriteLine("Totalcost:{0:c}", totalcost);   //?????
            Console.WriteLine("Totalincome:{0:c}", totalincome);
            Console.WriteLine("Totalprofit:{0:c}", profit);
            

            Console.WriteLine();
            Console.WriteLine("End of report");

            //QUESTIONS
            string hmr = "Hammers";
            Console.Write("Item number:{0}", hammersnumber);
            Console.WriteLine("{' ',40}Description:{0}", hmr); //question about space

        }
    }
}
