using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.specifications
{
    public class ProductSellerSpecification : ISpecification<Product>
    {

        private ProductSeller productSeller;

        public ProductSellerSpecification(ProductSeller productSeller)
        {
            this.productSeller = productSeller;
        }

        public bool IsSatisfied(Product t)
        {
            return t.TypeSeller == this.productSeller;
        }
    }
}
