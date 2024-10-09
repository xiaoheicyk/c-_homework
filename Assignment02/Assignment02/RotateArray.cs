namespace Assignment02;

public class RotateArray
{
    public void method()
    {
        Console.Write("Enter the array to rotate: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("Enter the number of rotate: ");
        int k = int.Parse(Console.ReadLine());
        int n = arr.Length;
        int[] sum = new int[n];
        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotated[(i + r) % n] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }

            Console.WriteLine("Rotated array after {0} rotations: {1}", r, string.Join(" ", rotated));
        }

        Console.WriteLine("Sum array: " + string.Join(" ", sum));
    }
}
