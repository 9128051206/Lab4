using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число s>0");
            int s=Convert.ToInt32(Console.ReadLine());
            for(int n=1, sum=0; n<=s; n++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", n, sum+=n*2-1);
                Console.ReadKey();
            }
           
        }   
    }
}
