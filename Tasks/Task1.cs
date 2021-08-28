using System.Collections.Generic;

namespace Tasks
{
    public class Task1
    {
        /*
         * Dada a lista de inteiros, retorne o maior número da lista         
         */
        public static int? GetMax(List<int> list) {
            int maiorNumero = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maiorNumero)
                {
                    maiorNumero = list[i];
                }
            }
            return maiorNumero;
        }
    }
}
