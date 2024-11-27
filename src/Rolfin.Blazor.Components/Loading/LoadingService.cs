namespace Rolfin.Blazor.Components.Loading;

public class LoadingService : ILoadingService
{
    private AsyncAction _show { get; set; }
    private AsyncAction _hide { get; set; }


    public void SetShowLoader(AsyncAction action) => _show = action;
    public void SetHideLoader(AsyncAction action) => _hide = action;


    public async Task ShowLoader() => await _show.Invoke();
    public async Task HideLoader() => await _hide.Invoke();
}
