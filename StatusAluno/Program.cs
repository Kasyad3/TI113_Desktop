namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("\n");
            Console.Write("Informe a nota 1");
            float nota1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.Write("Informe a nota 2");
            float nota2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            float soma = nota1 + nota2;
            float media = soma / 2;

            if (media >= 7)
            {
                Console.WriteLine($"A média de {nome} é {media}, Está APROVADO!");
            }
            
            
            else if (media >= 5)
            {
                Console.WriteLine($"A média de {nome} é {media}, Está Em RECUPERAÇÃO!");
            }
            else 
            {
                Console.WriteLine($"A média de {nome} é {media}, Está REPROVADO!");
            }

        }
    }
}
