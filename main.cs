using System;

namespace HelloWorld
{
    class Program
    {
		public static string DefaultGreeting = "Hello World.";
		
		static void PrintSeperator()
		{
			Console.WriteLine("#----------#");
		}
		
        static void Main(string[] args)
        {
			PrintSeperator();
            Console.WriteLine(DefaultGreeting);	
        }
    }
}
