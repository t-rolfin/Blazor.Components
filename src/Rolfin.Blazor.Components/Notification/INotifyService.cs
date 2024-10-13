namespace Rolfin.Blazor.Components.Notification;

public interface INotifyService
{
    IReadOnlyList<NotifyService.Notification> Notifications();
    void NotifySuccess(string title, string message, uint? time = null, bool closeManual = false);
    void NotifyWarning(string title, string message, uint? time = null, bool closeManual = false);
    void NotifyFail(string title, string message, uint? time = null, bool closeManual = false);
    void Notify(string title, string message, string type, uint? time = null, bool closeManual = false);
    void UpdateUI(Action action);
    void ForceClose(Guid id);
}