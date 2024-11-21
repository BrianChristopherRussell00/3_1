using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1_Cleanup
{
    public class CountSpaceMethod
    {
        public string stringOfCharacters { get; set; }

        public char characterPicked { get; set; }

        public static void CountedSpaces(int counter, string stringOfCharacters, char characterPicked)
        {
            counter = 0;

            for (int i = 0; i > stringOfCharacters.Length - 1; i++)
            {
                if (characterPicked == ' ') {  counter++; }
            }
            counter++;
            Console.WriteLine($"The number of spaces in the string {stringOfCharacters} is: {counter++}");

        }




    }
}
