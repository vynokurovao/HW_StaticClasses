using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StaticClasses_task2
{
    public static class MyExtension
    {
        private static void swap(ref int op1, ref int op2)
        {
            int tmp = op1;
            op1 = op2;
            op2 = tmp;
        }

        public static void SortArray(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
    }
}
