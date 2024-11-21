using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1_Cleanup
{
    public class ConsecutiveNumber
    {

        public static int [] FindConsecutiveNumber()                      
        { int[] arrayOne = { 1, 3, 4, 5, 5, 6, 6, 7, 1, 1, 3, 4, 5, 6, 1, 1 };
            for (int i = 0; i < arrayOne.Length - 1; i++)
                if (arrayOne[i] == 1 && arrayOne[i + 1] == 1)   
                {                             
                arrayOne[i] = 0;
                arrayOne[i + 1] = 0;
                break;
                
                
                
                }   
            return arrayOne;
        }








    }
}
