using HomagGroup.Blazor3D.Extras.Core;

namespace HomagGroup.Blazor3D.Geometires;

/// <summary>
/// Creates extruded geometry from a path shape.
/// </summary>
public class ExtrudeGeometry : BufferGeometry
{
    public ExtrudeGeometry() : base("ExtrudeGeometry")
    {
    }

    /// <summary>
    /// Construcor with parameters.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> polygonal shape.</param>
    /// <param name="options"><see cref="ExtrudeGeometryOptions"/> options used for extrusion.</param>
    public ExtrudeGeometry(Shape shape, ExtrudeGeometryOptions options) : this()
    {
        Shape = shape;
        ExtrudeOptions = options;
    }

    /// <summary>
    /// <see cref="Shape"/> polygonal shape.
    /// </summary>
    public Shape Shape { get; set; } = new Shape();

    /// <summary>
    /// <see cref="ExtrudeGeometryOptions"/> options used for extrusion.
    /// </summary>
    public ExtrudeGeometryOptions ExtrudeOptions { get; set; } = new ExtrudeGeometryOptions();
}