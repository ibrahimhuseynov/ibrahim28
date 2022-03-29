using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "azad";
            int count = 21;
            Console.WriteLine(ExtentionMethods_.IsOdd(count));
            Console.WriteLine(ExtentionMethods_.IsEven(count));
            Console.WriteLine(ExtentionMethods_.IsContainsDigit(name));
            Console.WriteLine(ExtentionMethods_.ToCapitalize(name));
            Console.WriteLine(ExtentionMethods_.GetValueIndexes(name,'a'));


            Console.ReadLine();
        }
    }
}
