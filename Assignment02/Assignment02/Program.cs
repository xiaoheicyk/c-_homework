
//Practice array

using System.Diagnostics;
using Assignment02;

public class Program
{
    static void q1()
    {
        ArrayCopy arrayCopy = new ArrayCopy();
        arrayCopy.Copy();
    }

    static void q2()
    {
        GroceyList myList = new GroceyList();
        myList.GroceryList();
    }

    static void q3()
    {
        Console.WriteLine("Enter the range to find primes: ");
        Console.Write("Enter the start number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the end number: ");
        int end = Convert.ToInt32(Console.ReadLine());
        FindPrimes myFindPrimes = new FindPrimes();
        int[] primeList = myFindPrimes.FindPrimesInRange(start, end);
        Console.Write($"The prime numbers between {start} and {end} are: ");
        foreach (var p in primeList)
        {
            Console.Write(p + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Assignment 02: practice with arrays");
        Console.WriteLine("============================================================");
        //q1();
        //q2();
        q3();
        

    }
}