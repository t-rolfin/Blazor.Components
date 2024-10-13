namespace Rolfin.Blazor.Components.Loading;

public interface ILoadingService
{
    void SetHideLoader(Action action);
    void SetShowLoader(Action action);

    void ShowLoader();
    void HideLoader();
}