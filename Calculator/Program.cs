//Following this tutorial => https://youtu.be/4oxS33D9-T4?si=dKR9aeYkdeXX0v37

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Changed ints to floats because floats will not round the tenths place up, and when dividing smaller nums by bigger nums an int will make it a whole number and therefore, inaccurate.
            float num1;
            float num2;
            string answer;
            float result;

            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("\nPlease enter your first number.");
            #region Notes
            //Variables
            //The four basic data types
            //string - Stores text, e.g. names or addresses
            //int - Stores whole numbers
            //float - Stores numbers with decimals
            //bool - Stores true or false
            #endregion
            //Casting - Converting one data type to another, Readlines are always strings out of the box
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease Enter your second number.");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\nWhat type of operation would you like to do?");
            Console.WriteLine("\nPlease enter...\n\na) Addition\ns) Subtraction\nm) Multiplication\nany other key) Division\n\n");
            answer = Console.ReadLine().ToLower();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                //need to make the result different if the denominator is 0
                //used turnary operator to see if the denominator == 0 and if it is, float.NaN(Not A Number) and we deal with it below in the next if,else statement
                result = num2 == 0 ? float.NaN : num1 / num2;
            }

            if (float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by 0!");
            }
            else
            {
                Console.WriteLine("\nThe result is " + result);
            }

            Console.WriteLine("\n\nThank you for using the calculator program!\n");

            Console.ReadKey();
        }
    }
}
