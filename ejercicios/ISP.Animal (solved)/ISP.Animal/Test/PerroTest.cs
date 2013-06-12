using ISP.Animal.Model;
using NUnit.Framework;

namespace ISP.Animal.Test
{
    [TestFixture]
    class PerroTest
    {
        [Test]
        public void SinAlimentarNiAcariciar()
        {
            Mascota p = new Perro();
            Assert.That(p.GetEstado(), Is.EqualTo("quiero un hueso y quiero jugar"));
        }

        [Test]
        public void Alimentado()
        {
            Mascota p = new Perro();
            p.Alimentar();
            Assert.That(p.GetEstado(), Is.EqualTo("no quiero un hueso y quiero jugar"));
        }

        [Test]
        public void AlimentadoYacariciado()
        {
            Mascota p = new Perro();
            p.Alimentar();
            p.Acariciar();
            Assert.That(p.GetEstado(), Is.EqualTo("no quiero un hueso"));
        }
    }
}
