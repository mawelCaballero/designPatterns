using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class ProductCategorySpecification : ISpecification<Product>
    {

        private ProductCategory category;

        public ProductCategorySpecification(ProductCategory category)
        {
            this.category = category;
            
        }

        public bool IsSatisfied(Product t)
        {
            return t.Category == category;

            throw new NotImplementedException();
        }
    }
}
