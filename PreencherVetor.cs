namespace Programa03;

public static class PreencherVetor
{
    public static void Rodar()
    {
        int[] vetor = new int[10];

        string inseridos = String.Empty;

        for (int i = 0; i < vetor.Length; i++)
        {
            string? errorMsg = null;

            bool concluido = false;

            while (!concluido)
            {
                System.Console.WriteLine($"Iteração {i} de {vetor.Length - 1}");
                try
                {
                    Console.WriteLine("Qual número você deseja inserir no vetor?");
                    int num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Em qual index você deseja inserir o número {num}");
                    int index = int.Parse(Console.ReadLine()!);

                    vetor[index] = num;

                    inseridos += $"\nvetor[{index}] = {num}";

                    concluido = true;
                }
                catch (IndexOutOfRangeException)
                {
                    errorMsg = "Index inválido!";
                }
                catch (FormatException) {
                    errorMsg = "Número Inválido";
                }
                catch (Exception err)
                {
                    errorMsg = err.Message;
                }
                finally
                {
                    if (!String.IsNullOrEmpty(errorMsg))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMsg);
                        Console.ResetColor();
                    }
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(inseridos);
            Console.ResetColor();
        }
    }
}
