namespace PrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu Nome:");
            string nome = Console.ReadLine()!;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Informe a Nota 1: ");
            float nota1 = float.Parse(Console.ReadLine()!);
            //float nota1 = Convert.ToSingle(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Informe a Nota 2: ");
            float nota2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Informe a Nota 3: ");
            float nota3 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            float soma = nota1 + nota2 + nota3;
            float media = soma / 3;

            Console.WriteLine($"A média de {nome} é {media}");

            //string mensagem = "Hello, World!";
            //char caractere = 'S';

            //int numeroInteiro = 10;
            //double numeroComVirgula = 10.7;

            //bool estaAtivo = false;
            //bool expressao = numeroInteiro > numeroComVirgula;

            //DateTime data = DateTime.Now;

            //Console.WriteLine("Informe um numero");
            //numeroInteiro = int.Parse(Console.ReadLine()!);
            //numeroInteiro = Convert.ToInt32(Console.ReadLine());

        }
    }
}
