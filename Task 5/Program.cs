

class Program
{
    static void Main()
    {
        Console.Write("Введіть перший рядок: ");
        string input1 = Console.ReadLine();

        Console.Write("Введіть другий рядок: ");
        string input2 = Console.ReadLine();

        int result = string.Compare(input1, input2);

        if (result < 0)
        {
            Console.WriteLine(input1);
            Console.WriteLine(input2);
        }
        else if (result > 0)
        {
            Console.WriteLine(input2);
            Console.WriteLine(input1);
        }
        else
        {
            Console.WriteLine("Рядки ідентичні.");
        }
    }
}
