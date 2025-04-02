namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            string[] historico = new string[100];
            int contadorHistorico = 0;

            while (true)
            {
                decimal calculo = 0.0m;
                string resultadoOperacoes = "";

                Console.WriteLine("===============================");
                Console.WriteLine("Calculadora Tabajara");
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Historico");
                Console.WriteLine("S - Sair");
                Console.WriteLine("-------------------------------");
                Console.Write("Escolha a opção: ");
                string opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "S")
                {
                    Console.WriteLine("Você saiu do código");
                    break;
                }

                else if (opcao == "5")
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("Tabuada Tabajara");
                    Console.WriteLine("===============================");
                    Console.WriteLine("");

                    Console.Write("Qual tabuada você quer? ");
                    int numTabuada = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine($"{numTabuada} x {i} = {numTabuada * i}");
                    }
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("historico");
                    Console.WriteLine("===============================");
                    Console.WriteLine("");

                    for (int i = 0; i < contadorHistorico; i++)
                    {
                        Console.WriteLine(historico[i]);
                    }
                }

                Console.Write("Escolha o primeiro numero: ");
                decimal primeiroNum = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("Escolha o segundo numero: ");
                decimal segundoNum = Convert.ToDecimal(Console.ReadLine());


                if (opcao == "1")
                {
                    calculo = primeiroNum + segundoNum;
                    resultadoOperacoes = $"{primeiroNum} + {segundoNum} = {calculo}";

                    historico[contadorHistorico] = resultadoOperacoes;
                }

                else if (opcao == "2")
                {
                    calculo = primeiroNum - segundoNum;
                    resultadoOperacoes = $"{primeiroNum} - {segundoNum} = {calculo}";

                    historico[contadorHistorico] = resultadoOperacoes;
                }

                else if (opcao == "3")
                {
                    calculo = primeiroNum * segundoNum;
                    resultadoOperacoes = $"{primeiroNum} * {segundoNum} = {calculo}";

                    historico[contadorHistorico] = resultadoOperacoes;
                }

                else if (opcao == "4")
                {
                    if (segundoNum == 0)
                    {
                        while (segundoNum != 0)
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Não é possivel dividir um numero por 0");
                            Console.WriteLine("Por gentileza, digite um numero valido");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("");

                            segundoNum = Convert.ToDecimal(Console.ReadLine());
                        }
                    }

                    resultadoOperacoes = $"{primeiroNum} / {segundoNum} = {calculo}";

                    historico[contadorHistorico] = resultadoOperacoes;
                }

                Console.WriteLine($"{resultadoOperacoes}");

                contadorHistorico++;

                Console.ReadLine();
            }
        }
    }
}
