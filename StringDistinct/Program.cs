using System;
using System.Linq;

namespace StringDistinct
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter String1:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter String2:");
            string str2 = Console.ReadLine();
            var op1 = str1.DistinctFrom(str2);
            var op2 = str2.DistinctFrom(str1);
            Console.WriteLine("Op1:" + op1);
            Console.WriteLine("Op2:" + op2);
        }
    }
    
}
