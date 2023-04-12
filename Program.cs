using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53
Escreva um programa na linguagem que desejar onde calcule o percentual de representação que 
cada estado teve dentro do valor total mensal da distribuidora.
*/

namespace Faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sp= 67.836430;
            double rj = 36.67866;
            double mg = 29.22988;
            double es = 27.16548;
            double outros = 19.84953;

            double psp = 0;
            double prj = 0;
            double pmg = 0;
            double pes = 0;
            double poutros = 0;

            double total = (sp + rj + mg+ es + outros);


            psp = ((sp / total) * 100);
            prj = ((rj / total) * 100);
            pmg = ((mg/ total) * 100);
            pes = ((es/ total) * 100);
            poutros = ((outros/ total) * 100);

            decimal dpsp = Math.Round(Convert.ToDecimal(psp), 2);
            decimal dprj = Math.Round(Convert.ToDecimal(prj), 2);
            decimal dpmg = Math.Round(Convert.ToDecimal(pmg), 2);
            decimal dpes = Math.Round(Convert.ToDecimal(pes), 2);
            decimal dpoutros = Math.Round(Convert.ToDecimal(poutros), 2);

            Console.WriteLine("\tPercentual de Cada Cidade");

            Console.WriteLine("{0}%", dpsp);
            Console.WriteLine("{0}%", dprj);
            Console.WriteLine("{0}%", dpmg);
            Console.WriteLine("{0}%", dpes);
            Console.WriteLine("{0}%\n", dpoutros);

        }
    }
}
