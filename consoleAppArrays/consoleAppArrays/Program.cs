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

            int[] biggerArray; // doar l-am declarat
            biggerArray = new int[5];
            for (int i = 0; i < myInts.Length; i++)
            {
                biggerArray[i] = myInts[i];
            }

            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }
            string[] days = { "Luni", "Marti", "Miercuri", "Joi", "Vineri" };

            // string[] secondDays = days; // changes will be reflected 

            // array e variabila de tip referinta
            // (fata de variabila de tip heap)
            // orice operatiune as face asupra sursei se
            // va reflecta in a doua variabila
            // ceea ce copiez este indexul (pointerul spre memoria Heap)

            string[] secondDays = (string[]) days.Clone();
            int joi = Array.IndexOf(days, "Joi");
            int lastJoi = Array.LastIndexOf(days, "Joi");
            Array.Clear(days, 2, 2);

            Array.Reverse(days);



            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
            foreach (string day in days)
            {
                Console.WriteLine(day);
            }

            //  i++     =>  i+1
            //  i--     =>  i-1
            //  ++i     =>  
            //  --i     =>  
            for (int i = myInts.Length - 1; i >=0; i--)
            {
                Console.WriteLine(myInts[i]);
            }

            // matrice multidimensionale

            int[,] matrix = new int[2, 3]; // 2 randuri 3 coloane;
                                           // sau 2 arrayuri unu sub altu cu 3 elem fiecare

            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;

            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            matrix[1, 2] = 2;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {

            //    }
            //}

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.Write("\n");
            }
                    }
    }
}
