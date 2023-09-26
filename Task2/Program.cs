

class Program
{
    static int[] RotateRight(int[] arr, int k)
    {
        int n = arr.Length;
        int[] rotatedArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            rotatedArr[(i + k) % n] = arr[i];
        }

        return rotatedArr;
    }

    static void Main()
    {
        Console.Write("Enter the array of integers separated by spaces: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.Write("Enter the number of rotations (k): ");
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;
        int[] sum = new int[n];

        for (int r = 1; r <= k; r++)
        {
            arr = RotateRight(arr, 1);

            for (int i = 0; i < n; i++)
            {
                sum[i] += arr[i];
            }
        }

        Console.WriteLine("Arrays after each rotation:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Rotation {i + 1}: [{string.Join(", ", arr)}]");
        }

        Console.WriteLine("Sum array after each rotation:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Rotation {i + 1}: {sum[i]}");
        }
    }
}
