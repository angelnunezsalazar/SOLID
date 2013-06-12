using ISP.Animal.Model;
using NUnit.Framework;

namespace ISP.Animal.Test
{
    [TestFixture]
    class SerpienteTest
    {
        [Test]
        public void sinAlimentar()
        {
            Model.Animal s = new Serpiente();
            Assert.That(s.GetEstado(), Is.EqualTo("quiero una rata"));
        }

        [Test]
        public void alimentado()
        {
            Model.Animal s = new Serpiente();
            s.Alimentar();
            Assert.That(s.GetEstado(), Is.EqualTo("no quiero una rata"));
        }
    }
}
