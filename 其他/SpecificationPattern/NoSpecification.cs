using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    public class NoSpecification<T>:AbstractSpecification<T>
    {
        private ISpecification<T> _specification;

        public NoSpecification(ISpecification<T> specification)
        {
            _specification = specification;
        }

        public override bool isSatisfiedBy(T candidate)
        {
            return !_specification.isSatisfiedBy(candidate);
        }

    }
}
