namespace HomagGroup.Blazor3D.Materials;

/// <summary>
/// <para>Abstract base class for materials.</para>
/// <para>Materials describe the appearance of objects. They are defined in a mostly renderer-independent way, so you don't have to rewrite materials if you decide to use a different renderer.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/materials/Material">Material</a></para>
/// </summary>
public abstract class Material
{
    protected Material(string type)
    {
        Type = type;
    }

    public string Type { get; } = "Material";

    /// <summary>
    /// <para>Light color. 
    /// You can use <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value">web color values</a> to set up required color.
    /// Default value is "orange"</para>
    /// </summary>
    public string Color { get; set; } = "orange";

    /// <summary>
    /// Optional name of the object. Default is an empty string. It has not to be unique. 
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <a href="https://en.wikipedia.org/wiki/Universally_unique_identifier" target="_blank">Universal unique identifier</a> of this object instance. It's automatically assigned Guid, so it shouldn't be edited.
    /// </summary>
    public Guid Uuid { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Defines whether this material is transparent. This has an effect on rendering as transparent objects need special treatment and are rendered after non-transparent objects.
    /// When set to true, the extent to which the material is transparent is controlled by setting its opacity property.
    /// Default is false.
    /// </summary>
    public bool Transparent { get; set; }

    /// <summary>
    /// Float in the range of 0.0 - 1.0 indicating how transparent the material is. A value of 0.0 indicates fully transparent, 1.0 is fully opaque.
    /// If the material's transparent property is not set to true, the material will remain fully opaque and this value will only affect its color.
    /// Default is 1.0.
    /// </summary>
    public double Opacity { get; set; } = 1;

    /// <summary>
    /// Wether to have depth test enabled when rendering this material. Default is true.
    /// </summary>
    public bool DepthTest { get; set; } = true;

    /// <summary>
    /// Wether rendering this material has any affect on the depth buffer. Default is true.
    /// When drawing 2D overlays it can be useful to disable the depth writing in order to layer several things together without creating z-index artifacts.
    /// </summary>
    public bool DepthWrite { get; set; } = true;
}