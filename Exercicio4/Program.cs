namespace Exercicio4
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

            if (num1 > num2 && num1 > num3)
            {
                mensagem = $"O Número {num1} é Maior que {num2} e {num3}";
            }
            else if (num2 > num1 && num2 > num3)
            {
                mensagem = $"O Número {num2} é Maior que {num1} e {num3}";
            }
            else if (num3 > num1 && num3 > num2)
            {
                mensagem = $"O Número {num3} é Maior que {num1} e {num2}";
            }
            else if (num2 == num1 && num2 == num3)
            {
                mensagem = $"O Número {num2} é Igual á {num1} e {num3}";
            }

            else
            {
                mensagem = "Resposta invalida, Tente novamente!";
            }
            Console.WriteLine(mensagem);
        }
    }
}
