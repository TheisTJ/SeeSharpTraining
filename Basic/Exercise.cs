using System;
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
    }
}
