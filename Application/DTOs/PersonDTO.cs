using Models.Domain.Enums;

namespace Application.DTOs;

public record PersonDTO(Guid Id, EStatus Status, string Name, int Years, string Email, string Cnpj, DateTime CreationDate);