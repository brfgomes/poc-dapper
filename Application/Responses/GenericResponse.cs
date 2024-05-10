using Flunt.Notifications;

namespace Application.Responses;

// public record GenericResponse<T>(bool Success, T Data, List<Notification> Notifications);
public class GenericResponse<T>
{
    public GenericResponse(bool success, T data, IReadOnlyCollection<Notification>? notifications)
    {
        Success = success;
        Data = data;
        Notifications = notifications;
    }

    public bool Success { get; private set; }
    public T? Data { get; private set; }
    public IReadOnlyCollection<Notification>? Notifications { get; private set; }
}