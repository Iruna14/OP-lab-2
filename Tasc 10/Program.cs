

class Program
{
    static int CountPairsWithDifference(int[] arr, int k)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int count = 0;

        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        foreach (int num in arr)
        {
            if (k > 0)
            {
                if (frequency.ContainsKey(num + k))
                {
                    count++;
                }
            }
            else if (k == 0)
            {
                if (frequency[num] > 1)
                {
                    count++;
                }
            }
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Введіть елементи масиву, розділені пробілами: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        int[] arr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            arr[i] = int.Parse(inputArray[i]);
        }

        Console.Write("Введіть цільову різницю: ");
        int k = int.Parse(Console.ReadLine());

        int result = CountPairsWithDifference(arr, k);
        Console.WriteLine($"Кількість пар із різницею {k}: {result}");
    }
}
