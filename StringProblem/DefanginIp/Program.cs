
using DefanginIp;

internal class Program
{
    private static void Main(string[] args)
    {
        MaxOperations maxOperations = new MaxOperations();

        int[] mas = new int[] { 1, 2, 3, 4 };
        int[] mas2 = new int[] { 3, 1, 3, 4, 3 };
        int k = 5;
        int k2 = 6;



        Console.WriteLine(maxOperations.MaxOperation(mas,k));
        Console.WriteLine(maxOperations.MaxOperation(mas2,k2));



        Console.ReadKey();
    }
}