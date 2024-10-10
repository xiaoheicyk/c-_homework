// See https://aka.ms/new-console-template for more information

public class Program
{

    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n<=2 && n>=1)
        {
            return 1;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
        
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number you want to fibonacci: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write($"The result is {Fibonacci(n)} ");
    }
    
}