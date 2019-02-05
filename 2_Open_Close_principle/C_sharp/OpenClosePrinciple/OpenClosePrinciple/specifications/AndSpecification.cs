using System;

namespace OpenClosePrinciple.specifications
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> firstSpecification, secondSpecification;

        public AndSpecification(ISpecification<T> firstSpecification, ISpecification<T> secondSpecification)
        {
            this.firstSpecification = firstSpecification ?? throw new ArgumentNullException();
            this.secondSpecification = secondSpecification ?? throw new ArgumentNullException();
        }

        public bool IsSatisfied(T p)
        {
            return this.firstSpecification.IsSatisfied(p) && this.secondSpecification.IsSatisfied(p);

        }
    }
}
