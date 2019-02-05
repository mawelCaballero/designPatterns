using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Product
    {

        public string Name;

        public ProductCategory Category;

        public ProductSeller TypeSeller;

        public Product(string name, ProductCategory category, ProductSeller typeSeller)
        {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException(paramName: nameof(name) );
            this.Name = name;
            this.Category = category;
            this.TypeSeller = typeSeller;
        }

        public override string ToString()
        {
            return $"Product: {this.Name} Category: {this.Category.ToString()} Type of Selling: {this.TypeSeller.ToString()} ";
        }
    }
}
