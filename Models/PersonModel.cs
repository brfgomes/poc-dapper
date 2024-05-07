namespace Models.Domain;

public class PersonModel
{
    public string Name { get; set; }
    public int Years { get; set; }
    public DateTime CreationDate => DateTime.Now;
}