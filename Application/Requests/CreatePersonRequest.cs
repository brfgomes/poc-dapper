using System.ComponentModel.DataAnnotations;

namespace Application.Requests;
public class CreatePersonRequest(string Name, int Years, string Email, string Cnpj, int Status)
{
    public string Name { get; init; } = Name;
    public int Years { get; init; } = Years;
    public string Email { get; init; } = Email;
    public string Cnpj { get; init; } = Cnpj;
    public int Status { get; init; } = Status;
}