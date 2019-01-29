using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class ProductFilter
    {

        public static IEnumerable<Product> FilterProductsByCategory(IEnumerable<Product> products, 
            ProductCategory category)
        {
            foreach(var currentProduct in products)
            {
                if (currentProduct.Category == category)
                     yield return currentProduct;
            }

        }

        public static IEnumerable<Product> FilterProductsByCategory(IEnumerable<Product> products,
            ProductSeller typeSelling)
        {
            foreach (var currentProduct in products)
            {
                if (currentProduct.TypeSeller == typeSelling)
                    yield return currentProduct;
            }

        }

        public static IEnumerable<Product> FilterProductsByCategoryAndTypeSeller(IEnumerable<Product> products,
            ProductCategory typeCategory, 
            ProductSeller typeSelling)
        {
            foreach (var currentProduct in products)
            {
                if (currentProduct.TypeSeller == typeSelling && currentProduct.Category == typeCategory)
                    yield return currentProduct;
            }

        }
    }
}
