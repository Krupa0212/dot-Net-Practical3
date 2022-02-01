// See https://aka.ms/new-console-template for more information
using System;
class DoTheMath
{
  
    static void Main(string[] args)
    {
        int q, r;

        Console.WriteLine("Please Enter the numerator:");
        int num = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Please Enter the denominator:");
        int deno = Convert.ToInt32(Console.ReadLine());


        q = num / deno;
        r = num % deno;

        Console.WriteLine("Integer division result is : " + q);
        Console.WriteLine("with remainder " + r);


      
        Console.WriteLine($"Floating point division result is : {q}({r}/{deno})");


        
     

    }
}

