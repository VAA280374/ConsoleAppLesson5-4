using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            int vCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine(" ");
            for (int i = 1; i < array.Length; i = i + 2) 
            {
                if (array[i] >= 0)
                {
                    int vt = array[i];
                    // Console.Write(" {0} {1} ", i+1, vt);
                    vt = vt / 2;
                    if ((2 * vt) != array[i])
                    {
                        vCount++;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Количество нечетных положительных чисел стоящих на четных местах составляет : {0}", vCount);
            Console.ReadKey();
        }
    }
}
