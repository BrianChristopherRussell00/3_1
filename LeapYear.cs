using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1_Cleanup
{
    public class LeapYear
    {

        public static bool IsAleapYear(int yearEntered)     
        
        {
            
            if (((yearEntered % 4 == 0) && (yearEntered % 100 != 0)) || (yearEntered % 400 == 0))
            {
                  
                Console.WriteLine("{0} is a Leap Year.", yearEntered);
                return true;


            }
             Console.WriteLine("{0} is not a Leap Year.", yearEntered); 
            return false;




        }



    }
}
