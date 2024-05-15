using Models.Domain.Enums;
using Models.Domain.ValueObjects;

namespace Models.Domain;

public class PersonModel
{
    public PersonModel(Guid id, EStatus status, string name, int years, string email, Cnpj cnpj, DateTime creationDate) 
    {
        Id = id;
        Status = status;
        Name = name;
        Years = years;
        Email = email;
        Cnpj = cnpj;
        CreationDate = creationDate;
    }

    public Guid Id { get; private set; }
    public EStatus Status { get; private set; }
    public string Name { get; private set; }
    public int Years { get; private set; }
    public string Email { get; private set; }
    public Cnpj Cnpj { get; private set; }
    public DateTime CreationDate { get; private set; }
}