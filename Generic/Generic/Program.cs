using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Maximum maximum = new Maximum();
            int maxNum = maximum.MaxInteger(21, 46, 65);
            Console.WriteLine("Maximum Integer Value is:" + maxNum);

            double maxFloat = maximum.MaxFloat(1.5, 2.6, 1.4);
            Console.WriteLine("Maximum Float Value is: " + maxFloat);

            string maxString = maximum.MaxString("Apple","Banana","Watermelon");
            Console.WriteLine("Maximum String Value is: " + maxString);
        }
    
    }

}
