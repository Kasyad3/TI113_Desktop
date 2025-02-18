using System.Numerics;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";

            Console.Write("Informe o Primeiro Número:");
            float num1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("Informe o Segundo Número:");
            float num2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("Informe o Terceiro Número:");
            float num3 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n"); 
            Console.WriteLine("\n"); 
            Console.WriteLine("\n");

            // Encontrar o maior número entre os três usando Math.Max
            float maior = Math.Max(num1, Math.Max(num2, num3));

            // Encontrar o menor número entre os três usando Math.Min
            float menor = Math.Min(num1, Math.Min(num2, num3));


            // Verifica se todos os números são iguais
            if (num1 == num2 && num2 == num3)
            {
                mensagem = $"Os números {num1}, {num2} e {num3} são iguais.";
            }
            else
            {
                mensagem = $"O Maior Número é {maior} e o Menor Número é {menor}.";
            }

            Console.WriteLine(mensagem);
            
        }
    }
}
