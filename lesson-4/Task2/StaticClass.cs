using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class StaticClass
    {
        public static int CountDivByThree(int[] array)
        {
            int count = 0;
            if (array.Length % 2 == 0)
            {
                for (int i = 0; i < array.Length; i += 2)
                {
                    if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i += 2)
                {
                    if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

