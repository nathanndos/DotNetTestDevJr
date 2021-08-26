using System.Collections.Generic;

namespace Tasks
{
    public class Task3
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list) {
            int somatorio = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                {
                    somatorio += i;
                }
            }
            return somatorio;
        }
    }
}
