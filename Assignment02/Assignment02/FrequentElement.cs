namespace Assignment02;

public class FrequentElement
{
    public void frequentElement(int[] array)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int var in array)
        {
            if (!frequency.ContainsKey(var))
            {
                frequency.Add(var, 1);
            }
            else
            {
                frequency[var]++;
            }
        }
        int mostFrequentNumber = array[0];
        int maxFrequency = 0;
        foreach (int k in frequency.Keys)
        {
            if (frequency[k] > mostFrequentNumber)
            {
                mostFrequentNumber = k;
                maxFrequency = frequency[k];
            }
        }
        Console.WriteLine($"The number {mostFrequentNumber} is the most " +
                          $"frequent (occurs {maxFrequency} times)");
    }
}