namespace Application.Responses;

// public record GenericResponse<T>(bool Success, T Data, List<Notification> Notifications);
public class GenericResponse<T>
{
    public GenericResponse(bool success, T data, List<FluentValidation.Results.ValidationFailure>? errors)
    {
        Success = success;
        Data = data;
        Errors = errors;
    }

    public bool Success { get; private set; }
    public T? Data { get; private set; }
    public List<FluentValidation.Results.ValidationFailure> Errors { get; private set; }
}