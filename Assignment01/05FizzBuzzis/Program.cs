// See https://aka.ms/new-console-template for more information
// The original code, the byte can only hold values from 0 to 255. When it comes to 256,
// then it would be changed to 0 and do the for loop forever;

int max = 500;

// Check if max exceeds the byte range
if (max > byte.MaxValue)
{
    Console.WriteLine("Warning: The value of 'max' exceeds the maximum allowed value.");
}
else
{
    for (byte i = 1; i < max; i++)
    {
        Console.WriteLine(i);
    }
}
