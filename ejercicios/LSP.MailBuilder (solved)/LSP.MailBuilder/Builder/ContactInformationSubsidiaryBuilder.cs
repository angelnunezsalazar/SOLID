using System;
using System.Net.Mail;
using System.Text;
using LSP.MailBuilder.Model;

namespace LSP.MailBuilder.Builder
{
    class ContactInformationSubsidiaryBuilder : IMailBuilder<ContactInformationSubsidiary>
    {
        private MailMessage mailMessage;
        private StringBuilder body = new StringBuilder();

        public ContactInformationSubsidiaryBuilder()
        {
            mailMessage = new MailMessage();
        }

        public IMailBuilder<ContactInformationSubsidiary> WithTo(string to)
        {
            mailMessage.To.Add(to);
            return this;
        }

        public IMailBuilder<ContactInformationSubsidiary> WithSubject(string subject)
        {
            mailMessage.Subject = subject;
            return this;
        }

        public IMailBuilder<ContactInformationSubsidiary> WithFrom(string from)
        {
            mailMessage.From = new MailAddress(from);
            return this;
        }

        public MailMessage BuildMessage()
        {
            mailMessage.Body = body.ToString();
            return mailMessage;
        }

        public IMailBuilder<ContactInformationSubsidiary> WithEntity(ContactInformationSubsidiary contact)
        {
            AddBodyLine("Nombre: {0}", contact.FirstName);
            AddBodyLine("Apellido: {0}", contact.LastName);
            AddBodyLine("Sucursal: {0}", contact.Subsidiary);
            return this;
        }

        private void AddBodyLine(String line, params object[] args)
        {
            body.AppendLine(String.Format(line, args));
        }
    }
}
