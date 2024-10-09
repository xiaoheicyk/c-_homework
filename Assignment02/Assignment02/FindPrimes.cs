namespace Assignment02;

public class FindPrimes
{
    static bool isPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public int[] FindPrimesInRange(int start, int end)
    {
        int[] primes = new int[0];
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (isPrime(i))
            {
                Array.Resize(ref primes, primes.Length + 1);
                primes[count] = i;
                count += 1;
            }
        }

        return primes;
    }
}