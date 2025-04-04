string[] historico = new string[100];
int contadorHistorico = 0;
int qtdOperacoesRealizadas = 0;

while (true)
{
    Console.WriteLine("=================================");
    Console.WriteLine("Calculadora Tabajara");
    Console.WriteLine("=================================");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - historico");
    Console.WriteLine("S - Sair");

    //--------------
    qtdOperacoesRealizadas++;
    //--------------

    decimal resultado = 0.0m;
    string strResultado = "";

    Console.WriteLine("---------------------------------");
    Console.Write("Escolha a opção: ");
    string option = Console.ReadLine();
    Console.WriteLine("---------------------------------");

    if (option.ToUpper() == "S")
    {
        Console.WriteLine("Você saiu do código :(");
        break;
    }

    //-----------------------------------------------
    if (option == "5")
    {
        string linhaTabuada = "";
        Console.WriteLine("=================================");
        Console.WriteLine("Tabuada");
        Console.WriteLine("=================================");
        Console.Write("Qual tabuada você quer? ");
        int qtdNumTabuada = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("O numerador que você escolheu vai ser multiplicado quantas vezes? ");
        int qtdNumTabuadaMultiplicada = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("=================================");
        for (int i = 0; i <= qtdNumTabuadaMultiplicada; i++)
        {
            Console.WriteLine($"{qtdNumTabuada} x {i} = {qtdNumTabuada * i}");
        }
        Console.WriteLine("=================================");

        Console.ReadLine();
        Console.Clear();
        continue;
    }

    else if (option == "6")
    {
        Console.WriteLine("=================================");
        Console.WriteLine("Historico das operações");
        Console.WriteLine("=================================");
        
        for(int i = 0; i < contadorHistorico; i++)
        {
            Console.WriteLine($"{historico[i]}");
        }        
        Console.WriteLine("---------------------------------");

        Console.ReadLine();
        Console.Clear();
        continue;
    }

    Console.Write("Escreva o primeiro numero: ");
    decimal primeiroNum = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("");

    Console.Write("Escreva o segundo numero: ");
    decimal segundoNum = Convert.ToDecimal(Console.ReadLine());

    if (option == "1")
    {
        resultado = primeiroNum + segundoNum;
        strResultado = $"{primeiroNum} + {segundoNum} = {resultado}";

        historico[contadorHistorico] = strResultado;
    }

    else if (option == "2")
    {
        resultado = primeiroNum - segundoNum;
        strResultado = $"{primeiroNum} - {segundoNum} = {resultado}";

        historico[contadorHistorico] = strResultado;
    }

    else if (option == "3")
    {
        resultado = primeiroNum * segundoNum;
        strResultado = $"{primeiroNum} * {segundoNum} = {resultado}";

        historico[contadorHistorico] = strResultado;
    }

    else if (option == "4")
    {
        if (segundoNum == 0)
        {
            while (segundoNum == 0)
            {
                Console.WriteLine($"Não é possivel dividir {primeiroNum} por 0");
                Console.WriteLine("Por gentileza, insira outro valor");
                Console.WriteLine("");

                Console.WriteLine("Qual o segundo valor? ");
                segundoNum = Convert.ToDecimal(Console.ReadLine());

                historico[contadorHistorico] = strResultado;

            }
        }

        resultado = primeiroNum / segundoNum;
        strResultado = $"{primeiroNum} / {segundoNum} = {resultado}";

        historico[contadorHistorico] = strResultado;
    }

    Console.WriteLine("");
    
    Console.WriteLine("=================================");
    Console.WriteLine($"O resultado é {strResultado}");
    Console.WriteLine("=================================");
    Console.WriteLine("");

    Console.Write("Deseja sair ou não da calculadora? ");
    string escolhaSair = Console.ReadLine();

    Console.WriteLine("");

    if (escolhaSair.ToUpper().Contains("S"))
    {
        Console.WriteLine("Você saiu do código :(");

        Console.ReadLine();
        contadorHistorico++;
        Console.Clear();
        break;
    }

    else if (escolhaSair.ToUpper().Contains("N"))
    {
        Console.Clear();

        Console.ReadLine();
        contadorHistorico++;
        Console.Clear();
        continue;
    }

    else if (!escolhaSair.ToUpper().Contains("S") && !escolhaSair.ToUpper().Contains("N"))
    {
        while (!escolhaSair.ToUpper().Contains("S") && !escolhaSair.ToUpper().Contains("N"))
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Palavra invalida!!!!");
            Console.Write($"Escreva 'Sim' ou 'Não': ");
            escolhaSair = Console.ReadLine();
        }

        if (escolhaSair.ToUpper().Contains("S"))
        {
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            Console.WriteLine("Você saiu do código :(");

            Console.ReadLine();
            contadorHistorico++;
            Console.Clear();
            break;
        }

        Console.ReadLine();
        contadorHistorico++;
        Console.Clear();
    }
    Console.WriteLine("---------------------------------");
}