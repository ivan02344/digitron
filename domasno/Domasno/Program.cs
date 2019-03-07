using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domasno
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;                   
            string operation;
            int answer;

            Console.Write("Enter the first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operation ( x , / , +, -) ");
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
            else
            {
                Console.WriteLine("Sorry that is not correct!");
                Console.ReadLine();
            }
        }
    }
}

