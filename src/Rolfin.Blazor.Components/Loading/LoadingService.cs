namespace Rolfin.Blazor.Components.Loading;

public class LoadingService : ILoadingService
{
    private Action _show { get; set; }
    private Action _hide { get; set; }


    public void SetShowLoader(Action action) => _show = action;
    public void SetHideLoader(Action action) => _hide = action;


    public void ShowLoader() => _show.Invoke();
    public void HideLoader() => _hide.Invoke();
}
