﻿
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
        Console.WriteLine("Add or delete element in array");
        GroceyList myList = new GroceyList();
        myList.GroceryList();
    }

    static void q3()
    {
        Console.WriteLine("Lets find the prime numbers between two numbers");
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

    static void q4()
    {
        Console.WriteLine("Lets rotate the array");
        RotateArray myRotateArray = new RotateArray();
        myRotateArray.method();
    }

    static void q5()
    {
        Console.WriteLine("Lets find the longest sequence in an array");
        Console.Write("Enter the array seperated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        LongestArray myLongestArray = new LongestArray();
        int[] result = myLongestArray.Longest(arr);
        Console.Write("The longest array is: ");
        foreach (int var in result)
        {
            Console.Write(var + " ");
        }
    }

    static void q6()
    {
        Console.WriteLine("Lets find the most frequent number in an array");
        Console.Write("Enter the array seperated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        FrequentElement myFrequentElement = new FrequentElement();
        myFrequentElement.frequentElement(arr);
    }
    static void Main()
    {
        Console.WriteLine("Assignment 02: practice with arrays");
        Console.WriteLine("============================================================");
        // copy array
        //q1();
        
        //add or delete item in list
        //q2();
        
        //find all primes between two numbers
        //q3();
        
        //rotate array
        //q4();
        
        //longest array
        //q5();
        
        //frequent integer
        q6();
        
        
        

    }
}