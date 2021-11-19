using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            Console.WriteLine();
            int N1 = Convert.ToInt32(Console.ReadLine());
            int N2 = N1;
            Console.WriteLine();
            int[,] number = new int[N1, N2];
            //Random random = new Random();
          
            for (int i = 0; i < N1; i++)
            {
                
                for (int j = 0; j < N2; j++)
                {
                    //number[i, j] = random.Next(0, 100);
                    number[i, j] = 1 - (i + j) % 2;
                    Console.Write("{0,3} ", number[i, j]);
                   
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
