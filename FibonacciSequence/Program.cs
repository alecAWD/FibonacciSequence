using System;

namespace FibonacciSequence
{
    internal class Program {
        int Fib(int n) {
            if(n <= 1) {
                return n;
            }
            Console.WriteLine("Fib: " + n + " : " + (n - 1) + " : " + (n - 2));
            return Fib(n - 1) + Fib(n - 2);
        }
        public static void Main(string[] args) {
            Console.WriteLine("Enter n for the sequence...");
            string? n = Console.ReadLine();
            int num = int.Parse(n);
            Program program = new Program();
            Console.WriteLine("Result: " + program.Fib(num));
        }
    }
}