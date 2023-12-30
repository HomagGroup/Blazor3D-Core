using HomagGroup.Blazor3D.Geometires.Lines;

namespace HomagGroup.Blazor3D.Objects;

public class Line : Object3D
{
    public Line() : base("Line")
    {
    }

    /// <summary>
    /// <para>Collection of <see cref="HomagGroup.Blazor3D.Materials.Material"/> (or derived classes) materials, defining the object's appearance.</para>
    /// </summary>
    public Material Material { get; set; } = new LineBasicMaterial();

    /// <summary>
    /// <para>An instance of <see cref="BufferGeometry"/> (or derived classes), defining the object's structure.</para>
    /// </summary>
    public BufferGeometry Geometry { get; set; } = new LineGeometry();
}