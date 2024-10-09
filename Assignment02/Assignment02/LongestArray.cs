namespace Assignment02;

public class LongestArray
{
    public int[] Longest(int[] array)
    {
        int n = array.Length;
        int longest = 1;
        int longestElement = array[0];
        int currentLength = 1;
        for (int i = 1; i < n; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > longest)
                {
                    longest = currentLength;
                    longestElement = array[i-1];
                }

                currentLength = 1;
            }
        }

        int[] result = new int[longest];
        for (int i = 0; i < longest; i++)
        {
            result[i] = longestElement;
        }

        return result;
    }
}