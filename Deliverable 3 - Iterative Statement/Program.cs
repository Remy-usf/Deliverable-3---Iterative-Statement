/* 
Author: Jurami Cajigas
Date: 1/31/2023
Description: C# console for iterative statements.
*/

namespace Deliverable_3___Iterative_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            try  //try catch to validate user input
            {
                while (true)  //keeps user input to between 1 and 100
                {

                    Console.WriteLine("Enter an integer value between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 0 && input <= 100)
                    {
                        break;
                    }

                }


                while (true)  //keeps user input to even or odd
                {
                    Console.WriteLine("");  //used for spacing
                    Console.WriteLine("Specify the series type: Even or Odd ");
                    series = Console.ReadLine();

                    if (series == "Even" | series == "even" || series == "Odd" | series == "odd")
                    {
                        break;
                    }

                    if (series != "Even" | series != "even" || series != "Odd" | series != "odd")
                    {
                        Console.WriteLine("Please only input a value of Even or Odd");  // put this in to alert users similar to try-catch
                    }
                }
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a valid integer value"); //alerts user
            }



            if (series == "Odd" | series == "odd")  //if odd then odd numbers are shown
            {
                Console.WriteLine("");
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even" | series == "even")  //if even then even numbers are shown
            {
                Console.WriteLine("");
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}