namespace Assignment02;

public class StringPalindrome
{
    public bool IsPalindrome(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string newStr = new string(charArray);
        if (newStr == s)
        {
            return true;
        }

        return false;
    }

    public void method(string str)
    {
        List<string> result = new List<string>();
        char[] delimiters = new char[] { ' ', ',', '!', '?', '(', ')', '.', ':', ';', '\'' };
        string[] words = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        foreach (string s in words)
        {
            if (IsPalindrome(s))
            {
                result.Add(s);
            }
        }
        result.Sort();

        for (int i = 0; i < result.Count; i++)
        {
            if (i == result.Count - 1)
            {
                Console.Write(result[i]);
            }
            else
            {
                Console.Write(result[i]+", ");
            }
        }

    }
}