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
            
int[,] poker = new int[4, 2] { { 13, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
System.Console.WriteLine(poker[0, 0]);
System.Console.WriteLine(poker[1, 0]);


//Para printar algum dado do array
//System.Console.WriteLine(array2D[0, 0]);
        }
    }
}
