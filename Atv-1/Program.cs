using System;

namespace Atv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //O contais é o metódo de verdadeiro ou falso.
            //(true) se o parâmetro value ocorrer dentro dessa instância; caso contrário, (false).
            
            string curso = "Meu computador é velho";
            Console.WriteLine($"Frase antes do uso do contains: {curso}");

            Console.WriteLine($"A frase contém a palavra computador?: {curso.Contains("computador")}");

        }
    }
}
