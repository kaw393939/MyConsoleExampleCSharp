using System;

namespace MyConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interpolated Strings https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine($"Hello {args[0]} {args[1]}");
        }
    }
}
