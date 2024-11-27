namespace Rolfin.Blazor.Components;

public class ParentNotProvidedException : Exception
{
    public ParentNotProvidedException() { }
    public ParentNotProvidedException(string message) : base(message) { }
    public ParentNotProvidedException(string message, Exception inner) : base(message, inner) { }
}
