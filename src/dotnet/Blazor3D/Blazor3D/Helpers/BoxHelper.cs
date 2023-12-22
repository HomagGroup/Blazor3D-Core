namespace HomagGroup.Blazor3D.Helpers;

/// <summary>
/// <para>Helper object to graphically show the world-axis-aligned bounding box around an object.</para>
/// <para>This object inherits from <see cref="Core.Object3D"/></para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/BoxHelper">BoxHelper</a></para>
/// </summary>
/// <inheritdoc><see cref="Core.Object3D"/></inheritdoc>
public sealed class BoxHelper : Object3D
{
    public BoxHelper() : base("BoxHelper")
    {
    }

    public BoxHelper(Object3D object3d = null!, string color = "0xffff00") : this()
    {
        Object3D = object3d;
        Color = color;
    }

    /// <summary>
    /// The <see cref="Object3D"/> to show the world-axis-aligned boundingbox.
    /// </summary>
    public Object3D Object3D { get; set; } = null!;

    public string Color { get; set; } = "0xffff00";

}