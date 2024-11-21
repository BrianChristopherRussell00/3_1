using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1_Cleanup
{   
public class EvenNumber 


    {
        public EvenNumber()
        {
            
        }
public static string EvenNumberFunction(int numbers)
        {
             numbers = 100;

            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < numbers; i += 2)
            {

                sb.Append(i);
                sb.Append(' ');
            }
            return sb.ToString();



        }



    }
}
