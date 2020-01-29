using System;

namespace Classes
{
    public class Calculadora
    {
        double num1;
        double num2;
        double resulfinal;
        double[] parametrosinfito;
        double[] parametrosinfitomed;
        double[] parametrospares;
        double somamedia;
        string operador;

        public void operacoes(string expresao)
        {

            string[] parametros = expresao.Split(';');
            if (parametros.Length == 3)
            {
                //Conversão
                try
                {
                    num1 = Convert.ToDouble(parametros[0]);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro na conversão do primeiro valor!");
                    Console.ResetColor();
                }

                try
                {
                    operador = Convert.ToString(parametros[1]);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro na conversão do operador!");
                    Console.ResetColor();
                }

                try
                {
                    num2 = Convert.ToDouble(parametros[2]);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro na conversãodo segundo valor!");
                    Console.ResetColor();
                }
                if (operador == "+" || operador == "Soma")
                {
                    resulfinal = soma(num1, num2);
                }
                else if (operador == "-" || operador == "Subtração")
                {
                    resulfinal = subtracao(num1, num2);
                }
                else if (operador == "*" || operador == "Multiplicacao")
                {
                    resulfinal = multiplicacao(num1, num2);
                }
                else if (operador == "/" || operador == "Divisão")
                {
                    if (num2 != 0)
                    {
                        resulfinal = divisao(num1, num2);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro divisão por 0");
                        Console.ResetColor();
                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operador inválido");
                    Console.ResetColor();
                }

            }

            else if (parametros.Length > 3)
            {
                string[] expresaovet = expresao.Split(';');
                parametrosinfito = new double[expresaovet.Length];
                for (int i = 0; i < expresaovet.Length; i++)
                {   //Tentar converter o vetor de string no vetor de double                    
                    try
                    {
                        parametrosinfito[i] = Convert.ToDouble(expresaovet[i]);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                resulfinal = soma(parametrosinfito);

            }

            Console.WriteLine(resulfinal);

        }

        //Soma
        private double soma(double primeiro, double segundo)
        {
            double resultado;
            resultado = primeiro + segundo;

            return resultado;
        }
        //Soma Sobrecarga
        private double soma(double[] listnumeros)
        {
            double resultado = 0.0;
            foreach (var item in listnumeros)
            {
                resultado += item;
            }
            return resultado;
        }

        //Subtração
        private double subtracao(double primeiro, double segundo)
        {
            double resultado;
            resultado = primeiro - segundo;
            return resultado;
        }

        //Multiplicação
        private double multiplicacao(double primeiro, double segundo)
        {
            double resultado;
            resultado = primeiro * segundo;
            return resultado;
        }

        //Divisão
        private double divisao(double primeiro, double segundo)
        {
            double resultado;
            resultado = primeiro / segundo;
            return resultado;
        }

        //Calculo de média inlimitada de elementos
        public void calcMediaInlimitElemen(string elemed)
        {
            string[] expresaovet = elemed.Split(';');
            double media;
            double qtd = expresaovet.Length;

            parametrosinfitomed = new double[expresaovet.Length];
            for (int i = 0; i < expresaovet.Length; i++)
            {   //Tentar converter o vetor de string no vetor de double                    
                try
                {
                    parametrosinfitomed[i] = Convert.ToDouble(expresaovet[i]);
                    somamedia += parametrosinfitomed[i];
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (qtd > 0)
            {
                media = somamedia / qtd;
                Console.WriteLine("A média é: " + media);

            }
            else
            {
                Console.WriteLine("Digite pelo menos um elemento para o calculo da média!");
            }
        }

        //Calculo números pares inlimitado
        public void calcSomaPares(string elementpar)
        {
            double somapares = 0;
            string[] elementospares = elementpar.Split(';');
            parametrospares = new double[elementospares.Length];

            for (int i = 0; i < elementospares.Length; i++)
            { //Tentar converter o vetor de string no vetor de double           
                try
                {
                    parametrospares[i] = Convert.ToDouble(elementospares[i]);

                    if (parametrospares[i] % 2 == 0)
                    {
                        somapares += parametrospares[i];
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
            Console.WriteLine("A soma de todos os pares é: " + somapares);

        }

    }
}