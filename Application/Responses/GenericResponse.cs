namespace Application.Responses;

public record GenericResponse<T>(bool Success, T Data);