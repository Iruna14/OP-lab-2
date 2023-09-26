
class Program
{
    static void FindLongestSequence(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("No sequence found.");
            return;
        }

        int start = 0; // Початковий індекс поточної послідовності
        int len = 1;   // Довжина поточної послідовності
        int bestStart = 0; // Початковий індекс найдовшої послідовності, знайденої до цього моменту
        int bestLen = 1;   // Довжина найдовшої послідовності, знайденої до цього моменту

        for (int pos = 1; pos < arr.Length; pos++)
        {
            if (arr[pos] == arr[pos - 1])
            {
                len++;
            }
            else
            {
                start = pos;
                len = 1;
            }

            if (len > bestLen)
            {
                bestStart = start;
                bestLen = len;
            }
        }

        Console.Write("Longest sequence of equal elements: ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of integers separated by spaces:");
        string input = Console.ReadLine();

      
        string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] arr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out int num))
            {
                arr[i] = num;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers separated by spaces.");
                return;
            }
        }

        FindLongestSequence(arr);
    }
}

