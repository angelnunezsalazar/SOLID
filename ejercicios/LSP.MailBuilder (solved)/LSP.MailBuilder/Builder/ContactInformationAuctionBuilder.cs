using System;
using System.Net.Mail;
using System.Text;
using LSP.MailBuilder.Model;

namespace LSP.MailBuilder.Builder
{
    class ContactInformationAuctionBuilder : IMailBuilder<ContactInformationAuction>
    {
        private MailMessage mailMessage;
        private StringBuilder body = new StringBuilder();

        public ContactInformationAuctionBuilder()
        {
            mailMessage = new MailMessage();
        }

        public IMailBuilder<ContactInformationAuction> WithTo(string to)
        {
            mailMessage.To.Add(to);
            return this;
        }

        public IMailBuilder<ContactInformationAuction> WithSubject(string subject)
        {
            mailMessage.Subject = subject;
            return this;
        }

        public IMailBuilder<ContactInformationAuction> WithFrom(string from)
        {
            mailMessage.From = new MailAddress(from);
            return this;
        }

        public MailMessage BuildMessage()
        {
            mailMessage.Body = body.ToString();
            return mailMessage;
        }

        public IMailBuilder<ContactInformationAuction> WithEntity(ContactInformationAuction contact)
        {
            AddBodyLine("Nombre: {0}", contact.FirstName);
            AddBodyLine("Apellido: {0}", contact.LastName);
            AddBodyLine("Autor: {0}", contact.Author);
            AddBodyLine("Dimensiones: {0}", contact.Dimensions);
            return this;
        }

        private void AddBodyLine(String line, params object[] args)
        {
            body.AppendLine(String.Format(line, args));
        }
    }
}
