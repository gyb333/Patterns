﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    public class OrSpecification<T>:AbstractSpecification<T>
    {
        private ISpecification<T> _leftSpecification;
        private ISpecification<T> _rightSpecification;

        public OrSpecification(ISpecification<T> leftSpecification,ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool isSatisfiedBy(T candidate)
        {
            return _leftSpecification.isSatisfiedBy(candidate) || _rightSpecification.isSatisfiedBy(candidate);
        }

    }


}
