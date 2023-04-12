using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

//Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número,
//ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.


namespace Test_Gupy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nF1 = 0;
            int nF2 = 1;
            int nF3 = 0;
          

            Console.WriteLine("Informe um número: ");
            int consulta = Int32.Parse(Console.ReadLine());

            while (consulta > nF3)
            {
                nF3 = nF1 + nF2;
                nF1 = nF2;
                nF2 = nF3;
            }


            if (consulta == 0 || consulta == 1)
            {
                Console.WriteLine("O valor pertence a sequência de Fibonacci");
            }
            else if (consulta == nF3)
            {
                Console.WriteLine("O valor pertence a sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine("O valor não pertence a sequência de Fibonacci");
            }

        }
    }
}
