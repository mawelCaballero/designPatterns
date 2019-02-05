using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    interface IFiltering<T>
    {
        /// <summary>
        /// Filter an items given a custom specification about the products to be filtered
        /// </summary>
        /// <param name="items"></param>
        /// <param name="specification"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteFilter(IEnumerable<T> items, ISpecification<T> specification);
    }
}
