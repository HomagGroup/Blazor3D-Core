namespace HomagGroup.Blazor3D.Geometires;

/// <summary>
/// <para>A class for generating a dodecahedron geometries.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/DodecahedronGeometry">DodecahedronGeometry</a></para>
/// </summary>
public class DodecahedronGeometry : BufferGeometry
{
    public DodecahedronGeometry() : base("DodecahedronGeometry")
    {
    }

    /// <summary>
    /// Constructor with parametes
    /// </summary>
    /// <param name="radius">Radius of the dodecahedron. Default is 1.</param>
    /// <param name="detail">Default is 0. Setting this to a value greater than 0 adds vertices making it no longer a dodecahedron.</param>
    public DodecahedronGeometry(double radius = 1, int detail = 0) : this()
    {
        Radius = radius;
        Detail = detail;
    }

    /// <summary>
    /// Radius of the dodecahedron. Default is 1.
    /// </summary>
    public double Radius { get; set; } = 1;

    /// <summary>
    /// Default is 0. Setting this to a value greater than 0 adds vertices making it no longer a dodecahedron.
    /// </summary>
    public int Detail { get; set; } = 0;
}