namespace Rolfin.Blazor.Components.Notification;

public class NotifyService : INotifyService
{
    private readonly List<Notification> _notifications = new();
    private Action _refresh = null;
    private uint _standardTime = 2;

    public void NotifySuccess(string title, string message, uint? time = null, bool closeManual = false)
        => Notify(title, message, "success", time, closeManual);

    public void NotifyFail(string title, string message, uint? time = null, bool closeManual = false)
        => Notify(title, message, "fail", time, closeManual);

    public void NotifyWarning(string title, string message, uint? time = null, bool closeManual = false)
        => Notify(title, message, "warning", time, closeManual);

    public void Notify(string title, string message, string type, uint? time = null, bool closeManual = false)
    {
        Notification notification = new(Guid.NewGuid(), title, message, type);

        var timeInSec = time is null ? _standardTime * 1000 : (uint)time * 1000;

        if(closeManual == false)
            notification.Time = new Timer((e) =>
            {
                _notifications.Remove(notification);
                _refresh?.Invoke();
            }, null, timeInSec, 1000);

        _notifications.Add(notification);
        _refresh?.Invoke();
    }


    public IReadOnlyList<Notification> Notifications() => _notifications.ToList().AsReadOnly();
    public void UpdateUI(Action action) => _refresh = action;
    public void ForceClose(Guid id)
    {
        var notification = _notifications.FirstOrDefault(x => x.Id == id);
        if (notification is not null) _notifications.Remove(notification);
    }


    public class Notification
    {
        public Notification(Guid id, string title, string message, string type)
        {
            Id = id;
            Title = title;
            Message = message;
            NotificationType = type;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public Timer Time { get; set; }
        public string NotificationType { get; set; }
    }
}
