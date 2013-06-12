using System.Net.Mail;
using LSP.MailBuilder.Builder;
using LSP.MailBuilder.Model;
using NUnit.Framework;

namespace LSP.MailBuilder.Test
{
    [TestFixture]
    class MailBuilderTest
    {
        [Test]
        public void TestContactInformation()
        {
            // arrange
            ContactInformation contactInformation = new ContactInformation()
            {
                FirstName = "Homero",
                LastName = "Simpson"
            };

            IMailBuilder<ContactInformation> mailBuilder = new ContactInformationMailBuilder();

            // act
            MailMessage message = mailBuilder
                                    .WithFrom("cliente@gmail.com")
                                    .WithTo("empresa@gmail.com")
                                    .WithSubject("Hola")
                                    .WithEntity(contactInformation).BuildMessage();

            // assert
            Assert.That(message.From.Address, Is.EqualTo("cliente@gmail.com"));
            Assert.That(message.To, Has.All.Matches<MailAddress>(x => x.Address == "empresa@gmail.com"));
            Assert.That(message.Subject, Is.EqualTo("Hola"));
            Assert.That(message.Body, Is.StringContaining("Nombre: Homero"));
            Assert.That(message.Body, Is.StringContaining("Apellido: Simpson"));
        }

        [Test]
        public void TestContactInformationSubsidiary()
        {
            // arrange
            ContactInformationSubsidiary contactInformation = new ContactInformationSubsidiary()
            {
                FirstName = "Homero",
                LastName = "Simpson",
                Subsidiary = "Retiro"
            };

            IMailBuilder<ContactInformation> mailBuilder = new ContactInformationMailBuilder();

            // act
            MailMessage message = mailBuilder
                                    .WithFrom("cliente@gmail.com")
                                    .WithTo("empresa@gmail.com")
                                    .WithSubject("Hola")
                                    .WithEntity(contactInformation).BuildMessage();

            // assert
            Assert.That(message.From.Address, Is.EqualTo("cliente@gmail.com"));
            Assert.That(message.To, Has.All.Matches<MailAddress>(x => x.Address == "empresa@gmail.com"));
            Assert.That(message.Subject, Is.EqualTo("Hola"));
            Assert.That(message.Body, Is.StringContaining("Nombre: Homero"));
            Assert.That(message.Body, Is.StringContaining("Apellido: Simpson"));
            Assert.That(message.Body, Is.StringContaining("Sucursal: Retiro"));
        }

        [Test]
        public void TestContactInformationAuctionSaleArtWork()
        {
            // arrange
            ContactInformation contactInformation = new ContactInformationAuction()
            {
                FirstName = "Homero",
                LastName = "Simpson",
                Author = "Picasso",
                Dimensions = "3x3"
            };

            IMailBuilder<ContactInformation> mailBuilder = new ContactInformationMailBuilder();

            // act
            MailMessage message = mailBuilder
                                    .WithFrom("cliente@gmail.com")
                                    .WithTo("empresa@gmail.com")
                                    .WithSubject("Hola")
                                    .WithEntity(contactInformation).BuildMessage();

            // assert
            Assert.That(message.From.Address, Is.EqualTo("cliente@gmail.com"));
            Assert.That(message.To, Has.All.Matches<MailAddress>(x => x.Address == "empresa@gmail.com"));
            Assert.That(message.Subject, Is.EqualTo("Hola"));
            Assert.That(message.Body, Is.StringContaining("Nombre: Homero"));
            Assert.That(message.Body, Is.StringContaining("Apellido: Simpson"));
            Assert.That(message.Body, Is.StringContaining("Autor: Picasso"));
            Assert.That(message.Body, Is.StringContaining("Dimensiones: 3x3"));
        }

    }
}
