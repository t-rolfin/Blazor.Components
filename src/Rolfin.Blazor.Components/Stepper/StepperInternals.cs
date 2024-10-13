namespace Rolfin.Blazor.Components.Stepper;

internal class StepStates
{
    public readonly static StepState Valid = new("valid", "bi bi-check2", "success", true);
    public readonly static StepState Invalid = new("invalid", "bi bi-x", "fail", false);
    public readonly static StepState Warning = new("warning", "bi bi-exclamation", "warning", true);
    public readonly static StepState None = new("none", "", "", null);
}

internal class StepState
{
    public StepState(string state, string iconCss, string bgColor, bool? isValid)
    {
        State = state;
        Icon = iconCss;
        BgColor = bgColor;
        IsValid = isValid;
    }

    public string State { get; set; }
    public string Icon { get; set; }
    public bool? IsValid { get; set; }
    public string BgColor { get; set; }
}
