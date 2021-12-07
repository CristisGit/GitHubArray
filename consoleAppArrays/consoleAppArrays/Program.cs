using System;

namespace consoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts; // doar l-am declarat
            myInts = new int[3]; // alocat spatiu de memorie pt int
            myInts[0] = 4;
            myInts[2] = 10;
            myInts[1] = 5;

            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }
            string[] days = { "Luni", "Marti", "Miercuri", "Joi", "Vineri" };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
