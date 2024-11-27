namespace Rolfin.Blazor.Components.Loading;

public delegate Task AsyncAction();

public interface ILoadingService
{
    void SetHideLoader(AsyncAction action);
    void SetShowLoader(AsyncAction action);

    Task ShowLoader();
    Task HideLoader();
}