using System.Net.Mail;

namespace LSP.MailBuilder.Builder
{
    public interface IMailBuilder<T>
    {
        IMailBuilder<T> WithTo(string to);
        IMailBuilder<T> WithSubject(string subject);
        IMailBuilder<T> WithFrom(string from);
        MailMessage BuildMessage();
        IMailBuilder<T> WithEntity(T entity);
    }
}
