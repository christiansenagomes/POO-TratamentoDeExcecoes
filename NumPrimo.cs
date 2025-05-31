namespace Programa01;

public static class NumPrimo
{
    public static void Rodar()
    {
        bool numValido = false;
        // Pegando a cor dos textos do console atual
        ConsoleColor consoleDefaultColor = Console.ForegroundColor;
        while(!numValido)
        {
            Console.WriteLine("Verificar se um número é primo");
            Console.WriteLine("Insira um número:");
            try
            {
                int numero = int.Parse(Console.ReadLine()!);
                bool isPrime = NumHelper.IsPrime(numero);

                if (isPrime)
                {
                    Console.WriteLine($"{numero} é um número primo");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um número primo");
                }
                // Permitindo que o loop acabe
                numValido = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número inválido!");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                throw;
            }
            // Mudando a cor dos textos no console para oq estava antes 
            Console.ForegroundColor = consoleDefaultColor;
        }
    }
}
