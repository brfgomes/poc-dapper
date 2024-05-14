using System.Text.Json.Serialization;
using Application.UseCases.Person;
using Flunt.Notifications;
using Models.Domain.Enums;

namespace Application.Requests;
public class CreatePersonRequest : Notifiable<Notification>
{
    public CreatePersonRequest(string name, int years, string email, string cnpj, int status)
    {
        Name = name;
        Years = years;
        Email = email;
        Cnpj = cnpj;
        Status = status;
        
        AddNotifications(new CreatePersonUseCaseContract(this));
    }

    public string Name{ get; private set; }
    public int Status { get; private set; }
    public int Years { get; private set; }
    public string Email { get; private set; }
    public string Cnpj { get; private set; }
}