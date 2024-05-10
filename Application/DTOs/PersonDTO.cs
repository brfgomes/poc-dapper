namespace Application.DTOs;

public record PersonDTO(Guid Id, string Name, int Years, string Email, string Cnpj, DateTime CreationDate);