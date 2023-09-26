

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated by spaces:");
        string input = Console.ReadLine();
        int[] sequence = input.Split().Select(int.Parse).ToArray();

        int mostFrequentNumber = FindMostFrequentNumber(sequence);

        Console.WriteLine($"The most frequent number is: {mostFrequentNumber}");
    }

    static int FindMostFrequentNumber(int[] sequence)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int maxFrequency = 0;
        int mostFrequentNumber = 0;

        foreach (int num in sequence)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }

            if (frequency[num] > maxFrequency || (frequency[num] == maxFrequency && num < mostFrequentNumber))
            {
                maxFrequency = frequency[num];
                mostFrequentNumber = num;
            }
        }

        return mostFrequentNumber;
    }
}

