using Flunt.Notifications;
using Models.Domain.Contracts;

namespace Models.Domain;

public class PersonModel : Notifiable<Notification>
{
    public PersonModel(Guid id, string name, int years, string email, string cnpj, DateTime creationDate) 
    {
        Id = id;
        Name = name;
        Years = years;
        Email = email;
        Cnpj = cnpj;
        CreationDate = creationDate;
        
        AddNotifications(new CreatePersonContract(this));
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int Years { get; private set; }
    public string Email { get; private set; }
    public string Cnpj { get; private set; }
    public DateTime CreationDate { get; private set; }
}