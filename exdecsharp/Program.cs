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
            ExibirMenu();
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
                    Console.WriteLine("\nEncerrando o programa... Pressione qualquer tecla para sair.");
                    executarPrograma = false;
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    Pausa();
                    break;
            }
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("         Menu de Opções             ");
        Console.WriteLine("====================================");
        Console.WriteLine("1 - Adicionar números à lista");
        Console.WriteLine("2 - Exibir números da lista");
        Console.WriteLine("3 - Calcular a soma dos números");
        Console.WriteLine("4 - Encerrar o programa");
        Console.WriteLine("------------------------------------");
        Console.Write("Escolha uma opção: ");
    }

    static void InserirNumeros()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("     Inserir Números                ");
        Console.WriteLine("====================================");
        Console.WriteLine("Insira os números para somá-los (insira 'done' para terminar): ");

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

        Pausa();
    }

    static void ExibirNumeros()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("     Números na Lista               ");
        Console.WriteLine("====================================");

        if (ListaDeSoma.Count == 0)
        {
            Console.WriteLine("A lista está vazia.");
        }
        else
        {
            for (int i = 0; i < ListaDeSoma.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {ListaDeSoma[i]}");
            }
        }

        Pausa();
    }

    static void CalcularSoma()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("     Cálculo da Soma                ");
        Console.WriteLine("====================================");

        int soma = 0;
        foreach (int numero in ListaDeSoma)
        {
            soma += numero;
        }

        Console.WriteLine($"A soma de todos os números inseridos é: {soma}");

        Pausa();
    }

    static void Pausa()
    {
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
    }
}
