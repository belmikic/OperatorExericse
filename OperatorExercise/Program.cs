using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var quotient = a / b;
            var remainder = a % b;

            if (a == 17 && b == 4)

                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder} ");

            else
                Console.WriteLine($"{a} / {b} is not {quotient} remainder {remainder}");

        }


         

    }
}
    

