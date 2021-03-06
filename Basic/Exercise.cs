﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Exercise
    {
        public void exercise1()
        {
            Console.WriteLine("Hello");
            Console.Write("Theis Trøjborg Jensen");
            Console.ReadLine();
        }
        public void exercise2()
        {
            Exercise2 e = new Exercise2();
            e.run();
        }
        public void exercise3()
        {
            Console.WriteLine("Dividing 1024 by 32");
            Console.WriteLine("Result: {0}", 1024 / 32);
            Console.ReadLine();
        }
        public void exercise4()
        {
            int output = -1 + 4 * 6;
            Console.WriteLine("-1 + 4 * 6 = {0}", output);
            output = (35 + 5) % 7;
            Console.WriteLine("(35 + 5) % 7 = {0}", output);
            output = 14 + -4 * 6 / 11;
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", output);
            output = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", output);
            Console.ReadLine(); 
        }
        public void exercise5()
        {
            int x, y, tmp;
            Console.WriteLine("Input the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            y = Convert.ToInt32(Console.ReadLine());

            tmp = x;
            x = y;
            y = tmp;

            Console.WriteLine("First number: {0}", x);
            Console.WriteLine("Second number: {0}", y);
            Console.ReadLine();
        }
        public void exercise6()
        {
            int a, b, c;
            Console.WriteLine("Input 3 numbers at a time to multiply them");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, a * b * c);
            Console.ReadLine();
        }
        public void exercise7()
        {
            int a, b;
            Console.WriteLine("Input the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);

            Console.ReadLine();
        }
        public void exercise8()
        {
            int x;
            Console.WriteLine("Enter the number");
            x = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", x, i, x * i);
            }
            Console.ReadLine();
        }
        public void exercise9()
        {
            int a, b, c, d;
            int avg;
            Console.WriteLine("Input the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the fourth number");
            d = Convert.ToInt32(Console.ReadLine());

            avg = (a + b + c + d) / 4;
            Console.WriteLine("The Average of {0}, {1}, {2} and {3} is {4}", a, b, c, d, avg);
            Console.ReadLine();
        }
        public void exercise10()
        {
            int x, y, z;
            Console.WriteLine("Input the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} * {2} = {3}", x, y, z, (x+y)*z);
            Console.WriteLine("{0} * {1} + {1} * {2} = {3}", x, y, z, x * y + y * z);

            Console.ReadLine();
        }
        public void exercise11()
        {
            int input;
            Console.Write("Enter your age: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", input);
            Console.ReadLine();
        }
        public void exercise12()
        {
            int input;
            Console.Write("Enter a digit: ");
            input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", input);
                Console.WriteLine("{0}{0}{0}{0}", input);
            }
            Console.ReadLine();
        }
        public void exercise13()
        {
            int input;
            Console.Write("Enter a digit: ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if(i == 0 ||i == 4)
                {
                    Console.WriteLine("{0}{0}{0}",input);
                    continue;
                }
                Console.WriteLine("{0} {0}", input);
            }

            Console.ReadLine();
        }
        public void exercise14()
        {
            double celsius, kelvin, fahrenheit;
            Console.Write("Enter the degree of celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            kelvin = 274.15 + celsius;
            fahrenheit = celsius * (9.0 / 5.0) + 32.0;

            Console.WriteLine("Celsius = {0}", celsius);
            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);

            Console.ReadLine();
        }
        public void exercise15()
        {
            string input = "w3resource";

            Console.WriteLine(input.Remove(1,1));
            Console.WriteLine(input.Remove(9,1));
            Console.WriteLine(input.Remove(0,1));

            Console.ReadLine();
        }
        public void exercise16()
        {
            Exercise16 e = new Exercise16();
            //Test strings
            string test1 = "w3resource";
            
            Console.WriteLine("Pre-swap: {0}",test1);
            Console.WriteLine("Swapped: {0}", e.swapFrontRear(test1));
            Console.ReadLine();
        }

        public void exercise17()
        {
            string input = "The quick brown fox jumps over the lazy dog.";
            char firstChar;

            char[] inputArray;
            inputArray = input.ToArray();
            firstChar = inputArray[0];

            Console.WriteLine(firstChar + input + firstChar);

            Console.ReadLine();
        }
        public void exercise18()
        {
            int first;
            int second;

            Console.WriteLine("Input first integer:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive");
            Console.WriteLine("Answer: {0}", ((first > 0 && second < 0)||(second > 0 && first < 0)));

            Console.ReadLine();
        }

        public void exercise19()
        {
            int first;
            int second;

            Console.WriteLine("Input first integer:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Checks if they are equals");
            Console.Write("Result: ");
            if (first == second)
            {
                Console.WriteLine("{0}",first*3);
            }
            else
            {
                Console.WriteLine("{0}", first * second);
            }

            Console.ReadLine();
        }

        public void exercise20()
        {
            int first;
            int second;

            Console.WriteLine("Input first integer:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result: ");
            if (second >= first)
            {
                Console.WriteLine("{0}", Math.Abs(second - first));
            }
            else
            {
                Console.WriteLine("{0}", Math.Abs(first - second) *2);
            }

            Console.ReadLine();
        }

        public void exercise21()
        {
            int first;
            int second;

            Console.WriteLine("Input first integer:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result: ");
            Console.WriteLine("{0}", first == 20 || second == 20 || first + second == 20);

            Console.ReadLine();
        }

        public bool helper22(int input, int range)
        {
            int lower = range - 20;
            int upper = range + 20;

            return input > lower && input < upper;
        }

        public void exercise22()
        {
            int input;

            Console.WriteLine("Input an integer:");
            input = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result: ");
            Console.WriteLine("{0}", helper22(input, 100)||helper22(input,200));

            Console.ReadLine();
        }

        public void exercise23()
        {
            String input;

            Console.WriteLine("Input an uppercase string:");
            input = Console.ReadLine();

            Console.Write("Result: ");
            Console.WriteLine("{0}", input.ToLower());

            Console.ReadLine();
        }

        public void exercise24()
        {
            String input;
            String longest = "";

            String[] words;
            
            

            Console.WriteLine("Input an uppercase string:");
            input = Console.ReadLine();

            words = input.Split(' ');

            foreach(String s in words)
            {
                if( s.Length > longest.Length)
                {
                    longest = s;
                }

            }
            Console.Write("Result: ");
            Console.WriteLine("{0}", longest);

            Console.ReadLine();
        }
    }
}
