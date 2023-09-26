

class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('a' + i);
        }

        Console.Write("Enter a lowercase word: ");
        string input = Console.ReadLine();

        Console.WriteLine("Indices of letters in the alphabet:");
        foreach (char letter in input)
        {
            int index = Array.IndexOf(alphabet, letter);
            if (index != -1)
            {
                Console.WriteLine($"{letter}: {index}");
            }
            else
            {
                Console.WriteLine($"{letter}: Not found in the alphabet");
            }
        }
    }
}

