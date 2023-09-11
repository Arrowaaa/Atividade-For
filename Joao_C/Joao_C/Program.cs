using System;

class Program
{
    static void Main()
    {
        bool continuarCadastrando = true;

        while (continuarCadastrando)
        {
            MostrarMenu();
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio1NumerosPares();
                    continuarCadastrando = Menu();
                    break;

                case 2:
                    Exercicio2SequenciaFibonacci();
                    continuarCadastrando = Menu();
                    break;

                case 3:
                    Exercicio3NumerosPrimos();
                    continuarCadastrando = Menu();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static bool Menu()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("\n Deseja Regressar ao MENU ? (s/n): ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "s")
        {
            Console.Clear();
            return true;
        }
        else if (resposta == "n")
        {
            Console.Clear();
            return false;
        }
        else
        {
            Console.WriteLine("Resposta inválida. Por favor, responda com 's' ou 'n'.");
            return Menu();
        }
    }

    static void MostrarMenu()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n MENU: ");
        Console.WriteLine("\n 1 - Exercício 1: Números Pares no Intervalo: ");
        Console.WriteLine("\n 2 - Exercício 2: Sequência de Fibonacci: ");
        Console.WriteLine("\n 3 - Exercício 3: Números Primos no Intervalo: ");
        Console.Write("\n Escolha a Opção: ");
    }

    static void Exercicio1NumerosPares()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\n Digite o número de início do intervalo: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("\n Digite o número de fim do intervalo: ");
        int fim = int.Parse(Console.ReadLine());

        Console.WriteLine(" Números pares no intervalo:");

        for (int i = inicio; i < fim; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Exercicio2SequenciaFibonacci()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\n Digite a posição da sequência desejada: ");
        int posicao = int.Parse(Console.ReadLine());

        if (posicao < 0)
        {
            Console.WriteLine("\n A posição deve ser um número não negativo.");
        }
        else
        {
            Console.WriteLine("\n Sequência até a posição: ", posicao);
            ImprimirSequenciaFibonacci(posicao);
        }
    }

    static void ImprimirSequenciaFibonacci(int n)
    {
        int a = 0, b = 1;

        for (int i = 0; i < n +1; i++)
        {
            Console.WriteLine(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
    }

    static void Exercicio3NumerosPrimos()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\n Digite um número inteiro positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 1)
        {
            Console.WriteLine("\n Nenhum número primo encontrado.");
        }
        else
        {
            Console.WriteLine("\n Números primos até {0}:", n);
            for (int i = 2; i <= n; i++)
            {
                if (EhPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
