using System;
using System.Threading;

namespace Calculator1
{
    class Program
    {
        // Simple Calculator Console Application.
        static void Main(string[] args)
        {
            bool programStatus = true;
            ConsoleKeyInfo keyValue;
            double number1;
            double number2;
            char operand;

            // The program is running in a do-while loop until the user chooses to end the program.
            do
            {
                Console.WriteLine("Simple Calculator");

                // Validation accept only positive and negative numbers.
                Console.Write("Enter the first number: ");
                bool number1ReturnValue = double.TryParse(Console.ReadLine(), out number1);
                while (number1ReturnValue == false)
                {
                    Console.Write("Enter a whole number or a decimal number: ");
                    number1ReturnValue = double.TryParse(Console.ReadLine(), out number1);
                }

                // Validation accept only one character and it have to be a specified operand.
                Console.Write("Enter the + - * / operand: ");
                bool operandReturnValue = char.TryParse(Console.ReadLine(), out operand);

                while (operandReturnValue == false)
                {
                    Console.WriteLine("Enter only one character.");
                    Console.Write("Enter the + - * / operand: ");
                    operandReturnValue = char.TryParse(Console.ReadLine(), out operand);
                }

                while (operand != '+' && operand != '-' && operand != '*' && operand != '/')
                {
                    Console.WriteLine(operand);
                    Console.Write("Enter the + - * / operand: ");
                    operandReturnValue = char.TryParse(Console.ReadLine(), out operand);
                }

                // Validation accept only positive and negative numbers.
                Console.Write("Enter the second number: ");
                bool number2ReturnValue = double.TryParse(Console.ReadLine(), out number2);
                while (number2ReturnValue == false)
                {
                    Console.Write("Enter a whole number or a decimal number: ");
                    number2ReturnValue = double.TryParse(Console.ReadLine(), out number2);
                }

                // Operand menu.
                switch (operand)
                {
                    case '+':
                        Console.WriteLine(Addition(number1, number2));
                        break;
                    case '-':
                        Console.WriteLine(Subtraction(number1, number2));
                        break;
                    case '*':
                        Console.WriteLine(Multiplication(number1, number2));
                        break;
                    case '/':
                        // Validation do not accept divide by zero.
                        while (number2 == 0)
                        {
                            Console.WriteLine("Dividend can not be zero");
                            Console.Write("Enter a whole number or a decimal number: ");
                            number2ReturnValue = double.TryParse(Console.ReadLine(), out number2);
                        }
                        Console.WriteLine(Division(number1, number2));
                        break;
                    // TODO: Is the default mandatory? Can it return a string?
                    default:
                        Console.WriteLine("Unknown");
                        break;
                }

                // The user decide if the program will continue or end.
                Console.WriteLine("Calculate another number? (Y/N)");

                keyValue = Console.ReadKey();

                if (keyValue.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.WriteLine("A new calculation");
                    programStatus = true;
                }
                else if (keyValue.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("The Simple Calculator will quit");
                    Console.WriteLine("Press Enter to terminate the Console Application");
                    programStatus = false;
                }
            }
            while (programStatus == true);
        }

        // Addition method.
        static double Addition(double number1Term, double number2Term)
        {
            double additionSum = number1Term + number2Term;
            return additionSum;
        }

        // Subtraction method.
        static double Subtraction(double number1Term, double number2Term)
        {
            double subtractionDifference = number1Term - number2Term;
            return subtractionDifference;
        }

        // Multiplication method.
        static double Multiplication(double number1Factor, double number2Factor)
        {
            double multiplicationProduct = number1Factor * number2Factor;
            return multiplicationProduct;
        }

        // Division method.
        static double Division(double number1dividend, double number2dividend)
        {
            double divisionFraction = number1dividend / number2dividend;
            return divisionFraction;
        }
    }
}
