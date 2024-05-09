namespace Models.Domain;

public class PersonModel
{
    public PersonModel(Guid id, string name, int years, DateTime creationDate)
    {
        Id = id;
        Name = name;
        Years = years;
        CreationDate = creationDate;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int Years { get; private set; }
    public DateTime CreationDate { get; private set; }
}