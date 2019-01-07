﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating variables
            int firstNum;
            int secondNum;
            string operation;

            //Name of calculator
            Console.WriteLine("The Best Worst Calculator!");
            Console.ReadLine();

            //request to user for 1st num
            Console.Write("Enter your first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            //request from user for second num
            Console.Write("Enter your second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            //request from user for operator
            Console.Write("Now enter your operator (x, /, +, -)");
            operation = Console.ReadLine();

            //logic for operators
            if (operation == "x")
            {

                Multiply(firstNum, secondNum);
            }

            else if (operation == "/")
            {

                Divide(firstNum, secondNum);
            }

            else if (operation == "+")
            {

                Add(firstNum, secondNum);
            }

            else if (operation == "-")
            {

                Subtract(firstNum, secondNum);
            }

            else {
                Console.WriteLine("Wrong format, please restart");
                Console.ReadLine();
            }


        }
        //Methods
        public static void Multiply(int firstNum, int secondNum) {
            int answer;
            answer = firstNum * secondNum;
            Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
            Console.ReadLine();
        }

        public static void Divide(int firstNum, int secondNum)
        {
            int answer;
            answer = firstNum / secondNum;
            Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
            Console.ReadLine();
        }

        public static void Add(int firstNum, int secondNum)
        {
            int answer;
            answer = firstNum + secondNum;
            Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
            Console.ReadLine();
        }

        public static void Subtract(int firstNum, int secondNum)
        {
            int answer;
            answer = firstNum / secondNum;
            Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
            Console.ReadLine();
        }



    }
}
