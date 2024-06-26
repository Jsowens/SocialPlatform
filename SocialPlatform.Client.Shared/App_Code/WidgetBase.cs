using Microsoft.AspNetCore.Components;

namespace SocialPlatform.Client.Shared;

public class WidgetBase : ComponentBase
{
    [Parameter] public RenderFragment? ChildContent { get; set; } = null;
    [Parameter] public string? Class { get; set; } = null;
    [Parameter] public string? Style { get; set; } = null;
    [Parameter] public string? Id { get; set; } = null;
    [Parameter] public string? Width { get; set; } = null;
    [Parameter] public string? Height { get; set; } = null;
    protected string FormattedStyle => SetHeight() + SetWidth() + Style;
    protected string SetHeight()
    {
        return Height != null ? "height: " + Height + ";" : "";
    }
    protected string SetWidth()
    {
        return Width != null ? "width: " + Width + ";" : "";
    }
}