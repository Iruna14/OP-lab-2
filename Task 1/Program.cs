

class Program
{
    static int FindLargestCommonEnd(string[] arr1, string[] arr2)
    {
        // Initialize variables to keep track of the longest common end.
        int startPosition = 0;
        int maxCommonEndLength = 0;

        // Determine the length of the shorter array.
        int minLength = Math.Min(arr1.Length, arr2.Length);

        // Find the common end from left to right.
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] == arr2[i])
            {
                maxCommonEndLength++;
            }
            else
            {
                break;
            }
        }

        // Find the common end from right to left.
        for (int i = 1; i <= minLength; i++)
        {
            if (arr1[arr1.Length - i] == arr2[arr2.Length - i])
            {
                maxCommonEndLength++;
                startPosition = i;
            }
            else
            {
                break;
            }
        }

        // Return the length of the longest common end.
        return maxCommonEndLength;
    }

    static void Main()
    {
        Console.WriteLine("Enter the first array of words separated by spaces:");
        string input1 = Console.ReadLine();
        string[] array1 = input1.Split(' ');

        Console.WriteLine("Enter the second array of words separated by spaces:");
        string input2 = Console.ReadLine();
        string[] array2 = input2.Split(' ');

        int result = FindLargestCommonEnd(array1, array2);
        Console.WriteLine("Length of the largest common end: " + result);
    }
}










