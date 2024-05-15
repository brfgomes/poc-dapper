using Application.Requests;
using FluentValidation;

namespace Application.UseCases.Person;

public class CreatePersonUseCaseContract : AbstractValidator<CreatePersonRequest>
{
    public CreatePersonUseCaseContract(CreatePersonRequest person)
    {
        RuleFor(person => person.Name)
            .NotEmpty().WithMessage("Nome nao pode ser vazio ou nulo.")
            .Length(4, 100).WithMessage("Nome precisa ter entre 4 e 100 caracteres");

        RuleFor(person => person.Years)
            .GreaterThan(0).WithMessage("A idade não pode ser menor que 0")
            .LessThanOrEqualTo(150).WithMessage("A idade não pode ser superior a 150");        
    }
}