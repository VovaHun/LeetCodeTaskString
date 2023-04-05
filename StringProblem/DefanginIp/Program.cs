
using DefanginIp;

internal class Program
{
    private static void Main(string[] args)
    {
        Stone stone = new Stone();


        
        Console.WriteLine(stone.NumJewelsInStones("aA", "aAAbbbb"));
        Console.WriteLine(stone.NumJewelsInStones("z", "ZZ"));
        Console.WriteLine(stone.NumJewelsInStones("bAx", "wwddbaxA"));
        Console.ReadKey();
    }
}