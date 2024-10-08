// See https://aka.ms/new-console-template for more information

// Playing with Console App
bool check = true;
string name;
int age;
double weight = 0 ;
double height = 0;

while (check)
{
    Console.Write("Hello, Input your name: ");
    name = Console.ReadLine();
    Console.Write("Input your age: ");
    age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input your weight (in Kg): ");
    weight = double.Parse(Console.ReadLine());
    Console.Write("Input your height (in cm): ");
    height = double.Parse(Console.ReadLine());
    Console.WriteLine("Your information are: ");
    Console.WriteLine($"Name:{name}");
    Console.WriteLine($"Age:{age}");
    Console.WriteLine($"Weight:{weight}");
    Console.WriteLine($"Height:{height}");
    Console.Write("All right? (y/n)");
    char input = char.Parse(Console.ReadLine());
    if (input == 'y' || input == 'Y')
    {
        check = false;
    }
}
double result = (weight)/(height/100 * height/100);
Console.WriteLine($"Your BMI is: {result}");