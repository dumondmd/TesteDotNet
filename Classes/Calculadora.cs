using System;

namespace Classes
{
    public class Calculadora
    {
        double num1;
        double num2;
        double resulfinal;
        double[] parametrosinfito;
        string operador;

        public void operacoes(string expresao)
        {
            Console.WriteLine("INÍCIO");
            Console.WriteLine("Seja bem vindo!!!");
            Console.WriteLine("_=Calculadora=_\n");            
            Console.WriteLine("Operações: soma, subtração, multiplicação, divisão");
            Console.WriteLine("Ex.:\n10;+;20");

            Console.WriteLine(expresao);

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
                    Console.WriteLine("Erro na conversão do primeiro valor!");
                }

                try
                {
                    operador = Convert.ToString(parametros[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro na conversão do operador!");
                }

                try
                {
                    num2 = Convert.ToDouble(parametros[2]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro na conversãodo segundo valor!");

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
                    if(num2 != 0){
                        resulfinal = divisao(num1, num2);
                    } else {
                        Console.WriteLine("Erro divisão por 0");                      
                    }
                    

                }
                else
                {
                    //Lançar exceção
                    Console.WriteLine("Operador inválido");
                }

            }

            else if (parametros.Length > 3)
            {
                string[] expresaovet = expresao.Split(';');
                parametrosinfito = new double[expresaovet.Length];
                for (int i = 0; i < expresaovet.Length; i++)
                {   //Tentar converter o vetor de string no vetor de double
                    Console.WriteLine(expresaovet[i] + " - " + expresaovet.Length);
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

            Console.WriteLine("FIM");
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
        private double calcMediaInlimitElemen()
        {
            return 0.0;
        }

        //ArquivoTexto


    }
}