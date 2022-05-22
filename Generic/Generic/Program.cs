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
            Console.WriteLine("Maximum Value:" + maxNum);
        }
    
    }

}
