// See https://aka.ms/new-console-template for more information

DateTime now = DateTime.Now;
Console.WriteLine($"Current time: {now.ToShortTimeString()}");
if (now.Hour >= 5 && now.Hour < 12)
{
    Console.WriteLine("Good Morning");
}

if (now.Hour >= 12 && now.Hour < 18)
{
    Console.WriteLine("Good Afternoon");
}

if (now.Hour >= 18 && now.Hour < 22)
{
    Console.WriteLine("Good Evening");
}

if (now.Hour >= 22 || now.Hour < 5)
{
    Console.WriteLine("Good Night");
}