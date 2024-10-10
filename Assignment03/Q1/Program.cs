
public class Program
{

    public static int[] GenerateNumbers(int n)
    {
        int[] numbers = new int[n];
        int temp = 1;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = temp;
            temp++;
        }

        return numbers;
    }

    public static void Reverse(int[] numbers)
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i]; 
            numbers[i] = numbers[numbers.Length - 1 - i]; 
            numbers[numbers.Length - 1 - i] = temp;
        }
    }

    public static void PrintNumbers(int[] numbers)
    {
        int last = numbers.Last();
        foreach (int n in numbers)
        {
            if (n != last)
            {
                Console.Write(n + ",");
            }
            else
            {
                Console.Write(n+".");
            }
        }
    }
    
    static void Main(string[] args)
    {
        Console.Write("Enter number you want to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = GenerateNumbers(n);
        Reverse(numbers);
        PrintNumbers(numbers);
    }
}