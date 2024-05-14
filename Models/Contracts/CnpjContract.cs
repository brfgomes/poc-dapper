using System.Text.RegularExpressions;
using Flunt.Validations;
using Models.Domain.ValueObjects;

namespace Models.Domain.Contracts;

public class CnpjContract : Contract<Cnpj>
{
    public CnpjContract(Cnpj cnpj)
    {
        Requires()
            .IsNotNullOrEmpty(cnpj.Value, "Cnpj", "Cnpj não pode ser vazio ou nulo")
            .IsTrue(cnpj.Value.Trim().Length == 14, "CNPJ", "O CNPJ deve ter exatamente 14 caracteres.")
            .IsTrue(Cnpj.ValidateCNPJ(cnpj.Value), "CNPJ", "O CNPJ não é válido.");
    }
}