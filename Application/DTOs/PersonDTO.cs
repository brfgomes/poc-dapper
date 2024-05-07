namespace Application.DTOs;

public class PersonDTO()
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Years { get; set; }
    public DateTime CreationDate { get; set; }
}