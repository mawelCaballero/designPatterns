using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  
    public interface ISpecification<T> 
    {
        /// <summary>
        /// Checks if any class is satified by this type
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool IsSatisfied(T t);
    }
}
