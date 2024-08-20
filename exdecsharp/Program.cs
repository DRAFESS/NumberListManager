using System;
using System.Collections.Generic;
using System.Threading;

class Programa
{
    static List<int> ListaDeSoma = new List<int>();

    static void Main(string[] args)
    {
        bool executarPrograma = true;

        while (executarPrograma)
        {
            Console.Clear();
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("1 - Para adicionar os números à lista");
            Console.WriteLine("2 - Para exibir os números da lista");
            Console.WriteLine("3 - Para realizar o cálculo de todos os números inseridos");
            Console.WriteLine("4 - Para encerrar o programa");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    InserirNumeros();
                    break;

                case "2":
                    ExibirNumeros();
                    break;

                case "3":
                    CalcularSoma();
                    break;

                case "4":
                    Console.WriteLine("Encerrando o programa...");
                    executarPrograma = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            if (executarPrograma)
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void InserirNumeros()
    {
        Console.Write("Insira os números para somá-los (insira 'done' para terminar): ");
        while (true)
        {
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "done")
            {
                break;
            }

            if (int.TryParse(entrada, out int numero))
            {
                ListaDeSoma.Add(numero);
                Console.WriteLine($"Número {numero} foi inserido.");
            }
            else
            {
                Console.WriteLine("Entrada inválida, tente novamente.");
            }
        }

        Thread.Sleep(2000);
        Console.Clear();
    }

    static void ExibirNumeros()
    {
        Console.WriteLine("Números na lista:");
        for (int i = 0; i < ListaDeSoma.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {ListaDeSoma[i]}");
        }
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }

    static void CalcularSoma()
    {
        int soma = 0;
        foreach (int numero in ListaDeSoma)
        {
            soma += numero;
        }

        Console.WriteLine($"A soma de todos os números inseridos é: {soma}");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}
