// See https://aka.ms/new-console-template for more information

class Program
{
    enum TimeUnit
    {
        Years = 1,
        Days = 365,
        Hours = 24,
        Minutes = 60,
        Seconds = 60,
        Milliseconds = 1000,
        Microseconds = 1000,
        Nanoseconds = 1000
    }

    static void Main()
    {
        Console.Write("Enter number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());

        long years = centuries * (int)TimeUnit.Years * 100; 
        long days = years * (int)TimeUnit.Days;
        long hours = days * (int)TimeUnit.Hours;
        long minutes = hours * (int)TimeUnit.Minutes;
        long seconds = minutes * (int)TimeUnit.Seconds;
        long milliseconds = seconds * (int)TimeUnit.Milliseconds;
        long microseconds = milliseconds * (int)TimeUnit.Microseconds;
        long nanoseconds = microseconds * (int)TimeUnit.Nanoseconds;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        Console.WriteLine($"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        

    }
}