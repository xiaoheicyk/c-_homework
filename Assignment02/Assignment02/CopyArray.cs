namespace Assignment02;

public class ArrayCopy
{
    public void Copy()
    {
        int[] originalArray = new int[10];

        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = i + 1;
        }
        int[] copiedArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        Console.WriteLine("original array:");
        foreach (int var in originalArray)
        {
            Console.Write(var + " ");
        }
        Console.WriteLine();
        Console.WriteLine("copied array:");
        foreach (int var in copiedArray)
        {
            Console.Write(var+" ");
        }
    }

}