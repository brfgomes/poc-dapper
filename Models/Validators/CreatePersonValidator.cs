using FluentValidation;
using Models.Domain;

public class CreatePersonModelValidator : AbstractValidator<PersonModel>
{
    public CreatePersonModelValidator()
    {
        RuleFor(person => person.Name)
            .NotEmpty().WithMessage("Nome não pode ser vazio ou nulo")
            .Length(4, 100).WithMessage("Nome precisa ter entre 4 e 100 caracteres");

        RuleFor(person => person.Years)
            .GreaterThan(0).WithMessage("Idade não pode ser menor que 0")
            .LessThanOrEqualTo(150).WithMessage("Idade não pode ser superior a 150");

        RuleFor(person => person.Email)
            .NotEmpty().WithMessage("Email não pode ser vazio ou nulo")
            .EmailAddress().WithMessage("Email inválido");
    }
}