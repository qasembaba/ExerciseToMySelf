using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExerciseToMySelf
{
    class Program
    {
        private static readonly IEnumerable<object> multiTabel;

        public static int[,] MultiTable { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(" hello world");
        }


        static void Arrays()
        {
            int[,] multiTable = new int[10, 10];

            foreach ( var item in multiTabel)
            {
                Console.WriteLine(item);
            }

            SetMultiNumbers(MultiTable);

            Console.WriteLine("after method call ");

            foreach (var item in multiTabel)
            {
                Console.WriteLine(item);
            }

        }
        static void SetMultiNumbers (int [,] tabel)
        {
            for (int i = 0;  i <=  10; i++  )
            {
                for (int x =0; x < 10; x++)
                {
                    tabel[i, x] = (i + 1) * (x + 1);
                }
            }
        }
    }
}
