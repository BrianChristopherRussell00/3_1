using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1_Cleanup
{
    public class CountSpaceMethod
    {
     

        public static int CountedSpaces(string input)
        {
            int counter = 0;

            foreach (char c in input)
            {
                if (c == ' ') {  counter++; }
            }
           return counter;

        }




    }
}
