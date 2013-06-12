namespace SRP
{
    using System.Xml;

    public interface IProductMapper
    {
        Product Map(XmlReader reader);
    }
}