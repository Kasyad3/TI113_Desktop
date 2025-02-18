namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";

            Console.Write("Informe seu nome:");
            string nome = Console.ReadLine()!;
            Console.WriteLine("\n");

            Console.Write("Informe quanto ganha por hora:");
            float salario = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
                
            Console.Write("Informe quantas horas trabalha por mês:");
            float cargaHoraria = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");

            float salarioTotal = salario * cargaHoraria;

            mensagem = $"O {nome} recebe no total por horas trabalhadas {salarioTotal}.";
            Console.WriteLine(mensagem);
        }
    }
}
