using System;

namespace Homework_29_04{
    internal class Program{
        static void Main(string[] args){

            //TASK 1
            Console.WriteLine("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            while (number < 0 || number > 100)
            {
                Console.WriteLine("ERROR!!!\nRe-enter your number: ");
                number = int.Parse(Console.ReadLine());
            }
            if (number % 3 == 0 && number % 5 != 0) Console.Write("Fizz");
            if (number % 5 == 0 && number % 3 != 0) Console.Write("Buzz");
            if (number % 3 == 0 && number % 5 == 0) Console.Write("Fizz Buzz");
            if (number % 3 != 0 && number % 5 != 0) Console.WriteLine(number);
            Console.Write("\n");


            //TASK 2
            /*Console.Write("Enter the number: ");
            float number = float.Parse(Console.ReadLine());
            Console.Write("Enter the percent: ");
            float percent = float.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + (number * (percent / 100)));*/

            //TASK 3
            /*Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int number4 = int.Parse(Console.ReadLine());
            int result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;
            Console.WriteLine("The result is " + result);*/

            //TASK 4
            /*Console.Write("Enter your number: ");
            string number = Console.ReadLine();
            while (number.Length != 6)
            {
                Console.Write("ERROR!!!\nRe-enter your number: ");
                number = Console.ReadLine();
            }
            Console.Write("Enter first position: ");
            int pos1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second position: ");
            int pos2 = int.Parse(Console.ReadLine());
            for (int i = 0;i < number.Length; i++)
            {
                if (i == pos1-1)
                {
                    Console.Write(number[pos2-1]);
                }
                else if (i == pos2-1)
                {
                    Console.Write(number[pos1-1]);
                }
                else
                {
                    Console.Write(number[i]);
                }
            }
            Console.Write("\n");*/

            //TASK 7
            /*Console.WriteLine("Enter first border: ");
            int left = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second border: ");
            int right = int.Parse(Console.ReadLine());
            while (left > right)
            {
                Console.WriteLine("ERROR!!!\nRe-enter first border: ");
                left = int.Parse(Console.ReadLine());
                Console.WriteLine("Re-enter second border: ");
                right = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even numbers from " + left + " to " + right +": ");
            for (int i = left; i <= right; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.Write("\n");*/
        }
    }
}
