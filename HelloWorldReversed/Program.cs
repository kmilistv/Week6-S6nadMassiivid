using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            Console.WriteLine("Sisesta Hello, World!:");
            string HelloWorld = Console.ReadLine();

            for (int i = HelloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(HelloWorld[i]);
            }

        }
    }
}
