using System;

namespace DemoNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            string prefix = "FASTCUP";
            Console.WriteLine("Enter prefix: ");
            string temp = Console.ReadLine();
            if (!string.IsNullOrEmpty(temp))
                prefix = temp;
            Console.WriteLine(prefix);

        }
    }
}
