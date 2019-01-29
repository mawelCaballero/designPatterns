using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Filter : IFiltering<Product>
    {
        public IEnumerable<Product> ExecuteFilter(IEnumerable<Product> items, 
            ISpecification<Product> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSatisfied(item))
                {
                    yield return item;
                }   
            }
        }
    }
}
