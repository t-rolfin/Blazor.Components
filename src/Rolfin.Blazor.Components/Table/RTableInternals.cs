namespace Rolfin.Blazor.Components;

internal class PageNumber
{
    public PageNumber(string name, int value, bool isActive = false)
    {
        Name = name;
        Value = value;
        IsActive = isActive;
    }

    public string Name { get; set; } = string.Empty;
    public int Value { get; set; }
    public bool IsActive { get; set; }
}

internal static class PageNumberExtensions
{
    public static void Add(this List<PageNumber> list, string name, int value) => list.Add(new(name, value));
}