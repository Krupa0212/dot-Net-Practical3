// See https://aka.ms/new-console-template for more information

using System;
using Prog32;
namespace Program
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            //1
            Console.WriteLine("\nEnter a string : ");
            String str = Console.ReadLine() ?? throw new Exception();
            Console.WriteLine($"String has length : {strings.Length(str)}");
            //2
            Console.WriteLine("\nEnter a sentence : ");
            String sentence = Console.ReadLine() ?? throw new Exception();
            if (strings.isDeclarative(sentence))
            {
                Console.WriteLine("It's a declarative sentence.");
            }
            else if (strings.isExclamation(sentence))
            {
                Console.WriteLine("It's a Exclamatory sentence");
            }
            else if (strings.isInterrogative(sentence))
            {
                Console.WriteLine("It's a interrogative sentence");
            }

            //3
            Console.WriteLine("\nEnter a name having first name and last name: ");
            String name = Console.ReadLine() ?? throw new Exception();

            strings.PrintName(name);
            //4
            Console.WriteLine("\nEnter a name : ");
            String sname = Console.ReadLine() ?? throw new Exception();
            strings.EnhancedPrintName(sname);
        }
    }
}
