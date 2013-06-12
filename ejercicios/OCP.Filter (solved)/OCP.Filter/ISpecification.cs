namespace OCP.Filter
{
    interface ISpecification
    {
        bool IsSatisfiedBy(Product product);
    }
}
