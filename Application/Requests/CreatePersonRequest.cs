using Application.UseCases.Person;
using Flunt.Notifications;

namespace Application.Requests;
public class CreatePersonRequest : Notifiable<Notification>
{
    public CreatePersonRequest(string name, int years, string email, string cnpj)
    {
        Name = name;
        Years = years;
        Email = email;
        Cnpj = cnpj;
        
        AddNotifications(new CreatePersonValidationUseCaseContract(this));
    }

    public string Name{ get; private set; }
    public int Years { get; private set; }
    public string Email { get; private set; }
    public string Cnpj { get; private set; }
}