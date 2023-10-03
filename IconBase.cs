using Microsoft.AspNetCore.Components;

namespace Flowbite.Icons;

public abstract class IconBase : ComponentBase
{
    /// <summary>
    /// Gets  additional attributes that will be applied to the svg child
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AdditionalAttributes { get; set; } = new();
}