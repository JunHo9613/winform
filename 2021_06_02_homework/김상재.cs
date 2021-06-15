using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _homework0601
{
    class Homework1
    {
        /* static void Main(string[] args)
         {
             int[,] a = { { 1, 2, 3, 4, } ,
                          { 5, 6, 7, 8, },
                          { 9, 10, 11, 12} };
             int[,] b = new int[4, 3];

             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     b[i, j] = a[j, i];
                     Console.Write(b[i, j] + " ");
                 }
                 Console.WriteLine();
             }


         }*/
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4, } ,
                         { 5, 6, 7, 8, } ,
                         { 9, 10, 11, 12, }};

            int[,] b = new int[4, 3];

            int idx = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    idx = i * 4 + j;

                    b[idx / 3 , idx % 3] = a[i, j];

                }

            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");

                }
                Console.WriteLine("");

            }






        }


    }
}

