using System;

namespace CalculateChange
{
    class CalculateChange
    {
        static void Main(string[] args)
        {
            double total = 0.92d;
           

            const double QUARTER = 0.25d;
            const double DIMES = 0.10;
            const double NICKELS = 0.05;
            const double PENNIES = 0.01;

            int quarter = (int)(total / QUARTER);
            double remaining1 = total % QUARTER;

            int dimes = (int)(remaining1 / DIMES);
            double remaining2 = remaining1 % DIMES;

            int nickels = (int)(remaining2 / NICKELS);
            double remaining3 = remaining2 % NICKELS;

            int pennies = (int)(remaining3 / PENNIES);
            double remaining4 = remaining3 % PENNIES;

            Console.WriteLine("25 note:{0}", quarter);
            Console.WriteLine("10 note:{0}", dimes);
            Console.WriteLine("5 note:{0}", nickels);
            Console.WriteLine("1 note:{0}", pennies);


            //it's still doesn'twork perfectly. it gives on one penny less... But at all it works.




        }
    }
}
