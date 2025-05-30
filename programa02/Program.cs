namespace programa02;

class Program
{
    static void Main(string[] args)
    {
        string[] operacoes = ["soma", "multiplicação", "subtração", "divisão", "módulo"];

        ConsoleColor corPadrao = Console.ForegroundColor;

        bool operacaoValida = false;
        string? errorMsg = null;

        int operacaoEscolhida = 0;
        double num1 = 0;
        double num2 = 0;

        while (!operacaoValida)
        {
            Console.WriteLine("Insira a operação desejada:");

            for (int i = 0; i < operacoes.Length; i++)
            {
                Console.WriteLine($"{i} - {operacoes[i]}");
            }

            try
            {
                operacaoEscolhida = int.Parse(Console.ReadLine()!);

                if (operacaoEscolhida > operacoes.Length - 1 || operacaoEscolhida < 0)
                {
                    throw new IndexOutOfRangeException("Operação inexistente!");
                }

                operacaoValida = true;

                bool err = true;
                while (err)
                {

                    try
                    {
                        Console.WriteLine("Primeiro número:");
                        num1 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Segundo número:");
                        num2 = double.Parse(Console.ReadLine()!);
                        err = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Insira um número válido");
                    }
                }

            }
            catch (FormatException)
            {
                errorMsg = "Número inválido!";
            }
            catch (Exception err)
            {
                errorMsg = "Erro! " + err.Message;
            }
            finally
            {
                Console.Clear();

                // Mostrar erro caso tenha
                if (!String.IsNullOrEmpty(errorMsg))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(errorMsg);
                    errorMsg = null;
                    Console.ForegroundColor = corPadrao;
                }
            }
        }

        switch (operacaoEscolhida)
        {
            case 0:
                Console.Write($"{num1} + {num2} = ");
                Console.WriteLine(CalculadoraHelper.Soma(num1, num2));
                break;
            case 1:
                Console.Write($"{num1} + {num2} = ");
                Console.WriteLine(CalculadoraHelper.Multiplicacao(num1, num2));
                break;
            case 2:
                Console.WriteLine(CalculadoraHelper.Subtracao(num1, num2));
                break;
            case 3:
                Console.WriteLine(CalculadoraHelper.Divisao(num1, num2));
                break;
            case 4:
                Console.WriteLine(CalculadoraHelper.Modulo(num1, num2));
                break;
        }
    }
}
