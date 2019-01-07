using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string operation;
            int answer;

            Console.WriteLine("The Best Worst Calculator!");
            Console.ReadLine();

            Console.Write("Enter your first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now enter your operator (x, /, +, -)");
            operation = Console.ReadLine();

            if (operation == "x")
            {

                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                Console.ReadLine();
            }

            else if (operation == "/")
            {

                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }

            else if (operation == "+")
            {

                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }

            else if (operation == "-")
            {

                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }

            else {
                Console.WriteLine("Wrong format, please restart");
                Console.ReadLine();
            }


        }

            
    }
}
