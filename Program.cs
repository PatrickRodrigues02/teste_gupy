using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Inverter_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strNormal = "", strInver = "";

            int[] numAR = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numAR.Length; i++)
            {
                strNormal += numAR[i];
            }

            int[] ARinver = new int[strNormal.Length];

            for (int i = 0; i <ARinver.Length; i++)
            {
                ARinver[i] = numAR[numAR.Length -1 - i];
            }

            for (int i = 0; i < ARinver.Length; i++)
            {
                strInver += ARinver[i];
            }

            Console.WriteLine(strNormal);
            Console.WriteLine(strInver);
        }
    }
}
