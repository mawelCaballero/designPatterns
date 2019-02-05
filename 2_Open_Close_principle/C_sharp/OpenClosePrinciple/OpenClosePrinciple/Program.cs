using OpenClosePrinciple.specifications;
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
                ProductSeller.STORE);

            var CondormanMovie = new Product("Condorman Blue ray", ProductCategory.BLUE_RAY,
                ProductSeller.ONLINE);

            var BattleZone = new Product("BattleZone PSVR", ProductCategory.GAMES, ProductSeller.STORE);


            Product[] products = { HereditaryMovie, CondormanMovie, BattleZone };


            var ProductsFiltered = ProductFilter.FilterProductsByCategory(products, ProductCategory.BLUE_RAY);
            Console.WriteLine("Filtrados por BlueRay con el Filtro Malo");

            PrintProducts(ProductsFiltered);

            var AdvancedFilterProducts = new Filter();

            ProductCategorySpecification productBlueRaysSpec = new ProductCategorySpecification(ProductCategory.BLUE_RAY);
            ProductSellerSpecification productSellerSpecification = new ProductSellerSpecification(ProductSeller.ONLINE);
            // Creates a new specification for another product by selling online 

            Console.WriteLine("Filtrados por BlueRay");
            PrintProducts(AdvancedFilterProducts.ExecuteFilter(products, productBlueRaysSpec));
            Console.WriteLine("Filtrados por Online");
            PrintProducts(AdvancedFilterProducts.ExecuteFilter(products, productSellerSpecification));
            Console.WriteLine("Filtrados por BlueRay y Online");
            PrintProducts(AdvancedFilterProducts.ExecuteFilter(products, new AndSpecification<Product>(productBlueRaysSpec, productSellerSpecification)));




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
