namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero de 1 a 7:");
            Console.WriteLine("\n"); 
            Console.WriteLine("\n");
            int dia = int.Parse(Console.ReadLine())!;

            if (dia == 1) {
                Console.WriteLine("Domingo");
            }
            
            else if (dia == 2) {
                Console.WriteLine("Segunda-Feira");
          
            } 
            else if (dia == 3) {
                Console.WriteLine("Terça-Feira");
          
            }
            else if (dia == 4) {
                Console.WriteLine("Quarta-Feira");
          
            }
            else if (dia == 5) {
                Console.WriteLine("Quinta-Feira");
          
            }
            else if (dia == 6) {
                Console.WriteLine("Sexta-Feira");
          
            }
            else if (dia == 7) {
                Console.WriteLine("Sábado");
          
            } 
            else {
                Console.WriteLine("Dígito Inválido");
          
            }


        }
    }
}
