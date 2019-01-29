using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            var HereditaryMovie = new Product("Hereditary Blue ray", ProductCategory.BLUE_RAY,
                ProductSeller.ONLINE);

            var CondormanMovie = new Product("Condorman Blue ray", ProductCategory.BLUE_RAY,
                ProductSeller.ONLINE);

            var BattleZone = new Product("BattleZone PSVR", ProductCategory.GAMES, ProductSeller.STORE);


            Product[] products = { HereditaryMovie, CondormanMovie, BattleZone };

            var ProductsFiltered = ProductFilter.FilterProductsByCategory(products, ProductCategory.BLUE_RAY);
            PrintProducts(ProductsFiltered);

            ProductCategorySpecification pts = new ProductCategorySpecification(ProductCategory.BLUE_RAY);

            var AdvancedFilterProducts = new Filter();
            var productsFilteredBySpec = AdvancedFilterProducts.ExecuteFilter(products, pts);
            PrintProducts(productsFilteredBySpec);


            

        }

        private static void PrintProducts(IEnumerable<Product> ProductsFiltered)
        {
            foreach (var filteredCurrentProduct in ProductsFiltered)
            {
                Console.WriteLine(filteredCurrentProduct.ToString());

            }
            Console.ReadKey();
        }
    }
}
