// See https://aka.ms/new-console-template for more information

Console.Write("Enter the number of levels for the pyramid: ");
int height;
while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
{
    Console.WriteLine("Please enter a valid positive integer.");
}

for (int i = 0; i < height; i++) // Outer loop for each line
{
    // First inner loop for printing spaces
    for (int j = height - i - 1; j > 0; j--)
    {
        Console.Write(" "); // Print space
    }
    // Second inner loop for printing stars
    for (int k = 0; k < (2 * i + 1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}