﻿namespace OCP.Filter
{
    using System.Collections.Generic;

    class SpecificationSize : ISpecification
    {
        private readonly Size productSize;

        public SpecificationSize(Size productSize)
        {
            this.productSize = productSize;
        }

        public bool IsSatisfiedBy(Product product)
        {
            return product.Size == this.productSize;
        }
    }
}
