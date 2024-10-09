namespace Assignment02;

public class StringReverseSentence
{
    static void reverseChar(char[] chars)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        char[] result = new char[chars.Length];
        
    }
    public void method(String str)
    {
        string[] strArray = str.Split(' ');
        int l = strArray.Length;
        Console.WriteLine(l);
        string[] result = new string[l];
        for (int i = 0; i < l; i++)
        {
            char[] temp = strArray[i].ToCharArray();
            temp.Reverse();
            
        }
        
    }
}