using System;
using Classes;

namespace TesteDotNet.Classes
{
    class Program
    {
        public static void menu()
        {
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("\tSeja bem vindo!!!\n");
                Console.WriteLine("\tDigite:");
                Console.WriteLine("> 1 - Calculadora");
                Console.WriteLine("> 2 - Arquivo de texto");
                Console.WriteLine("> 3 - Para  sair...");
                Console.WriteLine("------------------------------\n");
                String selecao = Console.ReadLine();
                if (selecao == "1")
                {
                    Console.Clear();
                    Calculadora calc = new Calculadora();

                    Console.WriteLine("> a - Calculadora normal");
                    Console.WriteLine("> b - Calculo da média");
                    Console.WriteLine("> c - Calculo da soma dos pares");
                    String selecaocalculo = Console.ReadLine();
                    if (selecaocalculo == "a")
                    {
                        Console.WriteLine("\tOperações: soma, subtração, multiplicação, divisão!!!\n");
                        Console.WriteLine("Ex.: 2;+;2");
                        String expressaocal = Console.ReadLine();
                        calc.operacoes(expressaocal);

                    }
                    else if (selecaocalculo == "b")
                    {
                        Console.WriteLine("\tCalculo da média!!!\n");
                        Console.WriteLine("Ex.: 10;5");
                        String media = Console.ReadLine();
                        calc.calcMediaInlimitElemen(media);

                    }
                    else if (selecaocalculo == "c")
                    {
                        Console.WriteLine("\tCalculo da soma dos pares!!!\n");
                        Console.WriteLine("Ex.: 2;4;6;8");
                        String somapares = Console.ReadLine();
                        calc.calcSomaPares(somapares);
                    }
                    else
                    {
                        menu();
                    }


                }
                else if (selecao == "2")
                {
                    Console.Clear();
                    IOArquivos.escrever();
                    IOArquivos.ler();
                }
                else if (selecao == "3")
                {
                    break;
                }

            } while (true);
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nossa calculadora");
        }
        static void Main(string[] args) =>
            menu();

    }
}

