using System;
using System.IO;
using System.Text;

namespace TesteDotNet.Classes
{
    public class IOArquivos
    {
        public static String caminho = "./arquivoescrito.txt";


        //Escrever os arquivo txt
        public static void escrever()
        {

            Console.WriteLine("Estou escrevendo...\n");
            try
            {

                using StreamWriter valor = new StreamWriter(caminho, false, Encoding.UTF8);
                valor.Flush();
                valor.WriteLine("José;Soma;10;2");
                valor.WriteLine("Adailtom;Divisão;10;2");
                valor.WriteLine("Raimundo;Multiplicacao;10;2");
                valor.WriteLine("Antonio;Subtração;10;2");
                valor.WriteLine("Joaquim;Subtração;10;2");
                valor.WriteLine("Paula;Divisão;10;2");
                valor.WriteLine();
                valor.WriteLine("DUMON DE MAGALHÃES DIAS;Soma;10;20;2;5;12");

                valor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro para escrever arquivo, eu fiz no Linux, tente mudar o diretorio(variavel caminho): " + e.Message);
            }

        }
        //Ler os arquivos
        public static void ler()
        {
            Console.WriteLine("Estou lendo...\n");
            string linha;

            using (StreamReader reader = new StreamReader(caminho))
            {
                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }

        }


    }
}
