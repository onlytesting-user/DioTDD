using CalculadoraConsole.Services;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            Console.WriteLine(calc.Somar(3, 5));
            Console.WriteLine(calc.Subtrair(9, 7));
            Console.WriteLine(calc.Multiplicar(3, 5));
            Console.WriteLine(calc.Dividir(12, 6));
            //Console.WriteLine(calc.Dividir(12, 0));

            List<string> historico = calc.Historico();
            Console.WriteLine("Operações anteriores:");
            foreach (var item in historico)
            {
                Console.WriteLine(item);
            }
        }
    }
}
