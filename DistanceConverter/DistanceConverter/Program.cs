using System;
using System.Reflection.Metadata.Ecma335;

namespace DistanceConverter
{
    class DistanceConverter
    {
        static void Main(string[] args)
        {
      
            double miles = 4.5d;

            const double FT_IN_MILE = 5280d;
            const double INCHES_IN_MILE = 63360d;
            const double KM_IN_MILE = 1.609344d;
            

            double feet = miles * FT_IN_MILE;
            double kms = miles * KM_IN_MILE;
            double inches = miles * INCHES_IN_MILE;

            Console.WriteLine("miles{0,22}", miles);
            Console.WriteLine();
            Console.WriteLine("feet{0,23}", feet);
            Console.WriteLine("inches{0,21}", inches);
            Console.WriteLine("kms{0,24:F2}", kms);
            Console.WriteLine();
            
            Console.ReadKey();

         

        }
    }
}
