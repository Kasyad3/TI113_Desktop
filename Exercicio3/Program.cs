namespace Exercicio3
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

            if (num1 > num2) {
                mensagem = $"O Número {num1} é Maior que {num2}";
            }
            else if (num2 > num1) {
                mensagem = $"O Número {num2} é Maior que {num1}";
            }
            else if (num2 == num1) {
                mensagem = $"O Número {num2} é Igual á {num1}";
            }

            else
            {
                mensagem = "Resposta invalida, Tente novamente!";
            }
            Console.WriteLine(mensagem);
        }
    }
}


