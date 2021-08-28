using System.Collections.Generic;
using System;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) {

            List<decimal> decimalList = new List<decimal>();

            decimal positivos = 0, negativos = 0, zeros = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    zeros++;
                }
                else if (numbers[i] > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }
   
            positivos = Math.Round(positivos / numbers.Count, 6);
            negativos = Math.Round(negativos / numbers.Count, 6);
            zeros = Math.Round(zeros / numbers.Count, 6);

            decimalList.Add(positivos);
            decimalList.Add(negativos);
            decimalList.Add(zeros);

            return decimalList;
        }
    }
}
