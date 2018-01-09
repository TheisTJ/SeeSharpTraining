using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Exercise2
    {
        static int add(int x, int y)
        {
            return x + y;
        }
        public void run()
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
