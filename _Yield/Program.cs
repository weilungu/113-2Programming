namespace Yield;

class Program
{
    static void Main(string[] args)
    {
        MyMath m =  new MyMath();

        int fib = m.Fibonacci(10);

        Console.WriteLine(fib);
    }
}