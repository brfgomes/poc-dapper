using Application.Requests;
using Flunt.Validations;
using Models.Domain;

namespace Application.UseCases.Person;

public class CreatePersonUseCaseContract : Contract<CreatePersonRequest>
{
    public CreatePersonUseCaseContract(CreatePersonRequest person)
    {
        Requires()
            .IsNotNullOrEmpty(person.Name, "Nome vázio ou nulo", "Nome nao pode ser vazio ou nulo.")
            .IsGreaterThan(person.Name.Length, 3, "Nome inválido", "Nome precisa ter mais que 3 caracteres")
            .IsLowerThan(person.Name.Length, 100, "Nome inválido", "Nome pode ter no máximo 100 caracteres")
            .IsGreaterThan(person.Years, 0, "Idade inválida", "A idade não pode ser menor que 0")
            .IsLowerThan(person.Years, 150, "Idade inválida", "A idade não pode ser superior a 150");
        
    }
}