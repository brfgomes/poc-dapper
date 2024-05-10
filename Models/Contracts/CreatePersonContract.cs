using System.Text.RegularExpressions;
using Flunt.Validations;

namespace Models.Domain.Contracts;

public class CreatePersonContract : Contract<PersonModel>
{
    public CreatePersonContract(PersonModel person)
    {
        Requires()
            .IsNotNullOrEmpty(person.Name, "Nome", "Nome não pode ser vazio ou nulo")
            .IsGreaterThan(person.Name.Length, 3, "Nome", "Nome precisa ter mais que 3 caracteres")
            .IsLowerThan(person.Name.Length, 100, "Nome", "Nome pode ter no máximo 100 caracteres")

            .IsNotNullOrEmpty(person.Name, "Idade", "Idade nao pode ser vazio ou nulo")
            .IsGreaterThan(person.Years, 0, "Idade", "Idade não pode ser menor que 0")
            .IsLowerThan(person.Years, 150, "Idade", "Idade não pode ser superior a 150")

            .IsNotNullOrEmpty(person.Email, "Email", "Nome não pode ser vazio ou nulo")
            .IsEmail(person.Email, "Email", "Email inválido")

            .IsNotNullOrEmpty(person.Cnpj, "Cnpj", "Cnpj não pode ser vazio ou nulo")
            .IsFalse(!Regex.IsMatch(person.Cnpj, @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$"), "CNPJ", "O CNPJ não é válido.");
    }
}