namespace Arraia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lembre-se, isso aqui é só um arquivo que utilizei pra testar como funcionam, e se sei fazer 
            // algumas funcionalidades do .NET e C#.
            // Espero que no futuro eu mude o mundo com programação, e programação tenha mudado minha vida
            // = Nicolas Rocha Lacerda, 14:25 - 27/07/2022.
            int a;
            int[,] poker = { { 1, 2, 3 }, { 4, 5, 6 } };

            System.Console.WriteLine("Essa arraia tem {0} dimensões.", poker.Rank);
            System.Console.WriteLine(poker.ToString()); 
            Console.WriteLine("Escreva um número");
            a = int.Parse(Console.ReadLine());
            int b = 0;
            {
                do
                {

                    Console.WriteLine(b);
                    b++;

                } while (b < a);
            }
        }
    }
}