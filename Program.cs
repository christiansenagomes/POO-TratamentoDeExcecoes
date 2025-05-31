namespace TratamentoDeExceções2;
using Programa01;
using Programa02;
using Programa03;
using Programa04;



class Program
{
    public static void Main()
    {
        int opcao = 0;

        while (opcao != -1)
        {
            Console.WriteLine("Verificar se é primo digite: 0");
            Console.WriteLine("Abrir calculadora digite: 1");
            Console.WriteLine("Preencher vetor digite: 2");
            Console.WriteLine("Soma e média digite: 3");

            switch (opcao)
            {
                case 0:
                    Programa01.NumPrimo.Rodar();
                    break;

                case 1:
                    Programa02.Calculadora.Rodar();
                    break;

                case 2:
                    Programa03.PreencherVetor.Rodar();
                    break;

                case 3:
                    Programa04.SomaNumeros.Rodar();
                    break;

                    
            }
        }
    }
}
