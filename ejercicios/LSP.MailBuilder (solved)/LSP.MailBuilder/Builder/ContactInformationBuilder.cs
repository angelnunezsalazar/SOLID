using System;
using System.Net.Mail;
using System.Text;
using LSP.MailBuilder.Model;

namespace LSP.MailBuilder.Builder
{
    public class ContactInformationBuilder : IMailBuilder<ContactInformation>
    {
        private MailMessage mailMessage;
        private StringBuilder body = new StringBuilder();

        public ContactInformationBuilder()
        {
            mailMessage = new MailMessage();
        }

        public IMailBuilder<ContactInformation> WithTo(string to)
        {
            mailMessage.To.Add(to); 
            return this;
        }

        public IMailBuilder<ContactInformation> WithSubject(string subject)
        {
            mailMessage.Subject = subject;
            return this;
        }

        public IMailBuilder<ContactInformation> WithFrom(string from)
        {
            mailMessage.From = new MailAddress(from);
            return this;
        }

        public MailMessage BuildMessage()
        {
            mailMessage.Body = body.ToString();
            return mailMessage;
        }

        public IMailBuilder<ContactInformation> WithEntity(ContactInformation contact)
        {
            AddBodyLine("Nombre: {0}", contact.FirstName);
            AddBodyLine("Apellido: {0}", contact.LastName);
            return this;
        }

        private void AddBodyLine(String line, params object[] args)
        {
            body.AppendLine(String.Format(line, args));
        }

    }
}
