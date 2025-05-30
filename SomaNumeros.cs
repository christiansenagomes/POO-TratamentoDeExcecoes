using System.Net.Http.Headers;

namespace SomaNumeros;

class SomaNumeros
{
    static void StatusSoma(double soma, int qntdNumeros)
    {
        double media;
        try
        {
            media = soma / qntdNumeros;
            if (Double.IsNaN(media))
            {
                throw new DivideByZeroException();
            }

        }
        catch (DivideByZeroException)
        {
            media = 0;
        }


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Valor somado: {soma}");
        Console.WriteLine($"Quantidade números somados: {qntdNumeros}");
        Console.WriteLine($"Média dos números somados: {media}");
        Console.ResetColor();
    }
    static void Main(string[] args)
    {
        double soma = 0;
        int qntdNumeros = 0;

        string? errorMsg = String.Empty;

        while (soma <= 100)
        {
            // Mostrar soma, quantidade de números somados e a média desses números
            StatusSoma(soma, qntdNumeros);

            try
            {
                System.Console.WriteLine("Número a ser somado:");
                double num = Double.Parse(Console.ReadLine()!);
                soma += num;
                if (soma > 100)
                {
                    throw new EExcecaoAcimaDeCem("100 é o número limite!");
                }
                qntdNumeros++;
            }
            catch (FormatException)
            {
                errorMsg = "Número inválido!";
            }
            catch (EExcecaoAcimaDeCem err)
            {
                errorMsg = err.Message;
            }
            finally
            {
                Console.Clear();
                if (!String.IsNullOrEmpty(errorMsg))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMsg);
                    Console.ResetColor();
                }
            }
        }
        StatusSoma(soma, qntdNumeros);
    }
}
