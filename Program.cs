using System.Data;
using System.Diagnostics.Metrics;
using System.Text;

namespace Assignment3_1_Cleanup
{
    internal class Program
    {
        static void Main(string[] args)
        {// Assignment 3.1 Part 1

            string listOfNumbers = EvenNumber.EvenNumberFunction(100);
            Console.WriteLine(listOfNumbers);


            //Assignment 3_1 Part 2

            Console.WriteLine("Enter a year : "); // Second Assignment 3_1
            int yearEntered = int.Parse(Console.ReadLine());
            Console.WriteLine(LeapYear.IsAleapYear(yearEntered));


            //Assignment 3_1 Part 3
            Console.WriteLine("Character Counter!");
            Console.WriteLine("Enter a string of characters:");
            string stringOfCharacters = Console.ReadLine();
            Console.WriteLine("What character are you looking for?");
            char characterPicked = char.Parse(Console.ReadLine());
            CountSpaceMethod.CountedSpaces(0, "daasd dsasd", ' ');

            //Assignment 3_1 Part 4

            int xcord, ycord;  // Declaration of integer variables co1 and co2 for X and Y coordinates

            Console.Write("Find the quadrant in which the coordinate point lies:\n");  // Displaying the purpose of the program


            Console.Write("Input the value for X coordinate :");  // Prompting user to input the X coordinate
            xcord = Convert.ToInt32(Console.ReadLine());  // Reading the input X coordinate from the user

            Console.Write("Input the value for Y coordinate :");  // Prompting user to input the Y coordinate
            ycord = Convert.ToInt32(Console.ReadLine());  // Reading the input Y coordinate from the user

            if (xcord > 0 && ycord > 0)  // Checking if X and Y coordinates are both positive
                Console.Write("The coordinate point ({0} {1}) lies in the First quadrant.\n\n", xcord, ycord);  // Printing a message for the first quadrant
            else if (xcord < 0 && ycord > 0)  // Checking if X coordinate is negative and Y coordinate is positive
                Console.Write("The coordinate point ({0} {1}) lies in the Second quadrant.\n\n", xcord, ycord);  // Printing a message for the second quadrant
            else if (xcord < 0 && ycord < 0)  // Checking if both X and Y coordinates are negative
                Console.Write("The coordinate point ({0} {1}) lies in the Third quadrant.\n\n", xcord, ycord);  // Printing a message for the third quadrant
            else if (xcord > 0 && ycord < 0)  // Checking if X coordinate is positive and Y coordinate is negative
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quadrant.\n\n", xcord, ycord);  // Printing a message for the fourth quadrant
            else if (xcord == 0 && ycord == 0)  // Checking if both X and Y coordinates are zero
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", xcord, ycord);  // Printing a message if the coordinates are at the origin        



            //Assignment 3_1 Part 5
            int[] arrayResults = ConsecutiveNumber.FindConsecutiveNumber();



        }






    }


}
