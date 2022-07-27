namespace Arraia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[,] poker = { { 1, 2, 3 }, { 4, 5, 6 } };

            System.Console.WriteLine("Essa arraia tem {0} dimensões.", poker.Rank);
            Console.WriteLine("Write a number");
            a = int.Parse(Console.ReadLine());
            for (int b = 0; b < a; b++)
                Console.WriteLine(b);
        }
    }
}