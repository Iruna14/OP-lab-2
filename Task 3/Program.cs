
class Program
{
    static void Main()
    {
       
        Console.WriteLine("Enter 4*k integers separated by spaces:");
        string input = Console.ReadLine();

        
        string[] inputArray = input.Split(' ');
        int[] integers = new int[inputArray.Length];

        
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (!int.TryParse(inputArray[i], out integers[i]))
            {
                Console.WriteLine("Invalid input. Please enter integers separated by spaces.");
                return;
            }
        }

        int k = integers.Length / 4;

        
        int[] upperRow = new int[2 * k];
        int[] lowerRow = new int[2 * k];

     
        for (int i = 0; i < k; i++)
        {
            upperRow[i] = integers[i] + integers[3 * k + i];
            lowerRow[i] = integers[k + i] + integers[2 * k + i];
        }

        
        int sumUpperRow = 0;
        int sumLowerRow = 0;

        for (int i = 0; i < 2 * k; i++)
        {
            sumUpperRow += upperRow[i];
            sumLowerRow += lowerRow[i];
        }

        
        Console.WriteLine("Sum of the upper row: " + sumUpperRow);
        Console.WriteLine("Sum of the lower row: " + sumLowerRow);
    }
}

