namespace Rolfin.Blazor.Components.Grid;

public interface ICard
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
    public string Image { get; set; }
    public int Position { get; set; }
}
