using System;
namespace MyConsolApp
{
    class MyConsoleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name please");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Hellow {0} !!!",name);
            Console.ReadKey();
        }    
    }
}
