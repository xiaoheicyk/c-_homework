namespace Assignment02;

public class StringReverse
{
    public void method(string input)
    {
        char[] charArray = input.ToCharArray(); 
        Array.Reverse(charArray); 
        string reversedString = new string(charArray);
        Console.Write("Reversed string (using for-loop): ");
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        
    }
}