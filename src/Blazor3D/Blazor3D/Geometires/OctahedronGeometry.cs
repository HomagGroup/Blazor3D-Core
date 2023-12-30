namespace HomagGroup.Blazor3D.Geometires;

/// <summary>
/// <para>A class for generating an octahedron geometry.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/OctahedronGeometry">OctahedronGeometry</a></para>
/// </summary>
public sealed class OctahedronGeometry : BufferGeometry
{
    public OctahedronGeometry() : base("OctahedronGeometry")
    {
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="radius">Radius of the octahedron. Default is 1.</param>
    /// <param name="detail">Default is 0. Setting this to a value greater than 0 adds more vertices making it no longer an octahedron.</param>
    public OctahedronGeometry(double radius = 1, int detail = 0) : this()
    {
        Radius = radius;
        Detail = detail;
    }

    /// <summary>
    /// Radius of the octahedron. Default is 1.
    /// </summary>
    public double Radius { get; set; } = 1;

    /// <summary>
    ///  Default is 0. Setting this to a value greater than 0 adds more vertices making it no longer an octahedron.
    /// </summary>
    public int Detail { get; set; } = 0;
}