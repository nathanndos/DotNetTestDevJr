using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock() {
            Repository repository = new Repository();
            List<string> produtosEstoqueZerado = new List<string>();

            for (int i = 0; i < repository.Products.Count; i++)
            {
                if(repository.Products[i].Stock.Quantity == 0)
                {
                    produtosEstoqueZerado.Add(repository.Products[i].Name);
                }
            }

            return produtosEstoqueZerado;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock() {
            Repository repository = new Repository();
            int somaTotal = 0;

            for (int i = 0; i < repository.Products.Count; i++)
            {
                somaTotal += repository.Products[i].Stock.Quantity;
            }

            return somaTotal;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity) {
            Repository repository = new Repository();

            foreach (Product product in repository.Products)
            {
                if (product.Id == productId)
                {
 
                    if(product.Stock.Quantity < orderQuantity)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
