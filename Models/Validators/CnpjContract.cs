using FluentValidation;
using Models.Domain.ValueObjects;

public class CnpjValidator : AbstractValidator<Cnpj>
{
    public CnpjValidator()
    {
        RuleFor(cnpj => cnpj.Value)
            .NotEmpty().WithMessage("Cnpj não pode ser vazio ou nulo")
            .Length(14).WithMessage("O CNPJ deve ter exatamente 14 caracteres.")
            .Must(Cnpj.ValidateCNPJ).WithMessage("O CNPJ não é válido.");
    }
}