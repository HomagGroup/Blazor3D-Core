namespace HomagGroup.Blazor3D.Lights;

/// <summary>
/// <para>Abstract base class for lights.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/lights/Light">Light</a></para>
/// </summary>
/// <inheritdoc><see cref="Object3D"/></inheritdoc>
public abstract class Light : Object3D
{
    protected Light(string type = "Light") : base(type)
    {
    }

    /// <summary>
    /// <para>Light color. 
    /// You can use <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value">web color values</a> to set up required color.
    /// Default value is "white"</para>
    /// </summary>
    public string Color { get; set; } = "white";

    /// <summary>
    /// <para>Value of the light's strength/intensity. Default is 1.</para>
    /// </summary>
    public double Intensity { get; set; } = 1;
}