namespace SRP
{
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IEnumerable<Product> GetByFileName(string fileName);
    }
}