using System;
using System.Collections.Generic;
using System.Text;

namespace SeeSharpTutorial
{
    class Program
    {
        static int add(int x, int y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Theis Trøjborg Jensen");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: {0} + {1} = {2}", x, y, add(x, y));
            Console.ReadLine();
        }
    }
}
