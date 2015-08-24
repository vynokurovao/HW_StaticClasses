using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StaticClasses_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7]{6, 7, 9, 3, 1, 6, 10};
            array.SortArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
