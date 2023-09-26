
class SieveOfEratosthenes
{
    static List<int> FindPrimes(int n)
    {
        List<int> primeNumbers = new List<int>();
        bool[] primes = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (primes[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                primeNumbers.Add(i);
            }
        }

        return primeNumbers;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        List<int> primeNumbers = FindPrimes(n);

        Console.WriteLine($"Prime numbers in the range [1...{n}]:");
        foreach (int prime in primeNumbers)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();
    }
}

