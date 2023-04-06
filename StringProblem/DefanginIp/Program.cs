
using DefanginIp;

internal class Program
{
    private static void Main(string[] args)
    {
        MaxOperations maxOperations = new MaxOperations();

        int[] mas = new int[] { 1, 2, 3, 4 };
        int[] mas2 = new int[] { 3, 1, 3, 4, 3 };
        int[] mas3 = new int[] { 4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4 };
        int k = 5;
        int k2 = 6;
        int k3 = 2;



        Console.WriteLine(maxOperations.MaxOperation(mas,k));
        Console.WriteLine(maxOperations.MaxOperation(mas2,k2));
        Console.WriteLine(maxOperations.MaxOperation(mas3,k3));



        Console.ReadKey();
    }
}