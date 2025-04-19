internal class Program
{
    static string[] historico = new string[100];
    static int contadorHistorico = 0;
    private static void Main(string[] args)
    {
        while (true)
        {
            string opcaoEscolhida = Menu();

            if (OpcaoInvalida(opcaoEscolhida))
            {
                MensagemErro();
            }

            else if (EscolheuSair(opcaoEscolhida))
            {
                break;
            }

            else if (EscolheuHistorico(opcaoEscolhida))
            {
                Historico();
            }

            else if (EscolheuTabuada(opcaoEscolhida))
            {
                Tabuada();
            }

            else
            {
                Calculos(opcaoEscolhida);
            }

            Console.ReadLine();
        }
    }

    static string Menu()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Calculadora");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Tabuada");
        Console.WriteLine("6 - Historico");
        Console.WriteLine("S - SAIR");
        Console.WriteLine("");
        Console.Write("Qual opcao voce escolhe? ");
        string opcaoEscolhida = Console.ReadLine()!;

        return opcaoEscolhida;
    }

    static bool OpcaoInvalida(string opc)
    {
        bool validador = opc != "1" && opc != "2" && opc != "3" && opc != "4" && opc != "5" && opc != "6";
        return validador;
    }

    static void MensagemErro()
    {
        Console.WriteLine("Sua escolha nao esta relacionado com o menu de escolhas. Tente novamente...");
        Console.ReadLine();
    }

    static bool EscolheuSair(string opc)
    {
        bool validador = opc == "S";
        return validador;
    }

    static bool EscolheuHistorico(string opc)
    {
        bool validador = opc == "6";
        return validador;
    }

    static void Historico()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Historico");
        Console.WriteLine("--------------------------------------------");

        for (int i = 0; i <= contadorHistorico; i++)
        {
            Console.WriteLine($"{i} - {historico[i]}");
        }

        //historico[i] = string
        //
    }

    static bool EscolheuTabuada(string opc)
    {
        bool validador = opc == "5";
        return validador;
    }

    static void Tabuada()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("--------------------------------------------");
        Console.Write("Qual tabuada voce quer? ");
        int tabuada = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
        }

    }

    static decimal Calculos(string opc)
    {
        decimal resultado = 0;

        Console.Write("qual o primeiro Numero? ");
        decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Qual o segundo Numero? ");
        decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

        if (opc == "1")
        {
            resultado = primeiroNumero + segundoNumero;
            historico[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
        }

        else if (opc == "2")
        {
            resultado = primeiroNumero - segundoNumero;
            historico[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
        }

        else if (opc == "3")
        {
            resultado = primeiroNumero * segundoNumero;
            historico[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
        }

        else
        {
            resultado = primeiroNumero / segundoNumero;
            historico[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
        }

        contadorHistorico++;

        return resultado;
    }

}