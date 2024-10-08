// See https://aka.ms/new-console-template for more information

int correctNumber = new Random().Next(3) + 1;
bool check = true;
Console.WriteLine("Welcome to the number generator!");
while (check)
{
    Console.Write("Please enter a number between 1 and 3: ");
    int guessedNumber = int.Parse(Console.ReadLine());
    if(guessedNumber == correctNumber)
    {
        Console.WriteLine("You entered the correct number!");
        check = false;
    }

    else if (guessedNumber > correctNumber)
    {
        Console.WriteLine("You entered a bigger number!");
    }
    else
    {
        Console.WriteLine("You entered the smaller number!");
    }
}