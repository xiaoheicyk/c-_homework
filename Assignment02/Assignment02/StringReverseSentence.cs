namespace Assignment02;

public class StringReverseSentence
{
    static bool IsDelimiter(char ch)
    {
        char[] delimiters = {'.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };
        foreach (char delimiter in delimiters)
        { 
            if (ch == delimiter)
            {
                return true;
            }
        }
        return false;
    }
    public string ReverseWords(string sentence)
    { 
        List<string> words = new List<string>();
        List<string> delimiters = new List<string>();
        
        int startIndex = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (IsDelimiter(sentence[i]))
            {
                if (startIndex < i) 
                {
                    words.Add(sentence.Substring(startIndex, i - startIndex));
                }
                delimiters.Add(sentence[i].ToString());
                startIndex = i + 1; 
            }
        }

        if (startIndex < sentence.Length)
        {
            words.Add(sentence.Substring(startIndex));
        }

        words.Reverse();

        string result = "";
        int wordIndex = 0;
        int delimiterIndex = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (delimiterIndex < delimiters.Count && i == result.Length)
            {
                result += delimiters[delimiterIndex++];
                continue;
            }

            if (wordIndex < words.Count && result.Length == i)
            {
                result += words[wordIndex++];
            }
            while (delimiterIndex < delimiters.Count && result.Length == i)
            {
                result += delimiters[delimiterIndex++];
            }
        }
        while (wordIndex < words.Count)
        {
            result += words[wordIndex++];
        }
        return result;
    }
}