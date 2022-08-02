using System;

namespace ExamAverage
{
    class ExamEverage
    {
        static void Main(string[] args)
        {
            const double exam1 = 82.53d;
            const double exam2 = 90.66d;
            const double exam3 = 74.52d;
            const double exam4 = 88.71d;
            const double exam5 = 80.39d;
            const double average = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;

            
            Console.WriteLine("Exam 1:{0,24:F2}", exam1);
            Console.WriteLine("Exam 2:{0,24:F2}", exam2);
            Console.WriteLine("Exam 3:{0,24:F2}", exam3);
            Console.WriteLine("Exam 4:{0,24:F2}", exam4);
            Console.WriteLine("Exam 5:{0,24:F2}", exam5);
            Console.WriteLine();
            Console.WriteLine("Average grade: {0,16:F2}", average);
        
        }
    }
}
