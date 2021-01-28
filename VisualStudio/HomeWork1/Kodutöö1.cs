using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string next = "Click enter to continue!";
            Console.ForegroundColor = ConsoleColor.Blue; //https://stackoverflow.com/questions/7937256/orange-text-color-in-c-sharp-console-application
            Console.WriteLine("Please Enter Your name!");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hello " +name + "!\n\nPlease enter two numbers!");
            double number1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Now the second number!");
            double number2 = Double.Parse(Console.ReadLine());

            double sum = number1 + number2;
            double minus = number1 - number2;
            double devide = number1 / number2;
            double product = number1 * number2;

            bool sqrtBool = sum >= 0;

            Console.WriteLine("\nQuick Calculations:\nAddition: " + sum + "\nSubtraction: " + minus + "\nDevision: " + devide + "\nMultiplication: " + product);

            if (sqrtBool == true)
            {
                double sqrt = Math.Sqrt(sum);
                Console.WriteLine("Sqrt: " + sqrt);

            }
            else
            {
                Console.WriteLine("Sorry! Sqrt is not possible with negative number!");
            }

            Console.WriteLine("\nNow let's take a look at another cool feature!\n" + next);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("IQ Test!\n\n1. How many bits are in byte? (6, 8, 16, or 64)");
            int corrects = 0;
            int answer1 = 8;
            int userAnswer1 = Int32.Parse(Console.ReadLine());

            if (answer1 == userAnswer1)
            {
                Console.WriteLine("Well done! " + userAnswer1 + " is correct!");
                corrects += 1;
            }
            else
            {
                Console.WriteLine("Sorry! " + userAnswer1 + " is not correct!");
            }
            Console.WriteLine("\n2. How much is 5 devided with 2?");
            double answer2 = 2.5;
            double userAnswer2 = Double.Parse(Console.ReadLine());

            if (answer2 == userAnswer2)
            {
                Console.WriteLine("Well done! " + userAnswer2 + " correct!");
                corrects += 1;
            }
            else
            {
                Console.WriteLine("Sorry! " + userAnswer2 + " is not correct!");
            }

            Console.WriteLine("\n3. Currency unit in Estonia?\n 1) Kroon\n 2) Ruble\n 3) Euro");
            string userAnswer3 = Console.ReadLine();

            if (userAnswer3 == "Euro")
            {
                Console.WriteLine("Well done! " + userAnswer3 + " is correct!\n");
                corrects += 1;
            }
            else if (userAnswer3 == "3") 
            {
                Console.WriteLine("Well done! " + userAnswer3 + " is correct!\n");
                corrects += 1;
            }
            else if (userAnswer3 == "euro")
            {
                Console.WriteLine("Well done! " + userAnswer3 + " is correct!\n");
                corrects += 1;
            }
            else
            {
                Console.WriteLine("Sorry! " + userAnswer3 + " is not correct!\n");
            }

            Console.WriteLine(corrects + " correct answere(s)!");

            if (corrects == 3)
            {
                Console.WriteLine("Great job!");
            }
            else
            {
                Console.WriteLine("Well maybe better luck next time! :)");
            }
            Console.WriteLine("Click enter to exit!");
            Console.ReadLine();  

        }
    }
}
