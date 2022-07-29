namespace Arraia
{
    public class Amazonia
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
            // Função faz um array 2d (4 Colunas, 2 linhas) e printa os dados na tela
            // é possivel especificar quantas colunas e linhas você quer como limite escrevendo
            // a quantidade com viruglas dentro de "new int[x,x]"
            
            int[,] poker = new int[,] { 
            { 7, 2 }, 
            { 3, 4 }, 
            { 5, 6 }, 
            { 7, 8 } };
            foreach (var item in poker)
            {
                Console.Write($"->{item}");
            }
            //Para printar algum dado em específicodo array
            //System.Console.WriteLine(array2D[0, 0]);
        }
    }
}
