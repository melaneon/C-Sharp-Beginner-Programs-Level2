using System;
using System.Runtime.CompilerServices;

namespace CalculateAnswer
{
    class CalculateAnswer
    {
        static void Main()
        {

            const int inches = 12;
            int x = 100; int y = 10;
            float z = 22.45f;
            double ans = inches + z * x % y;
 
            Console.WriteLine("The result is {0:f2}", +ans);
        }
    }
}