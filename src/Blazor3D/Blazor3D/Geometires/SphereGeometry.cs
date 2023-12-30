namespace HomagGroup.Blazor3D.Geometires;

/// <summary>
/// <para>A class for generating sphere geometries.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/SphereGeometry">SphereGeometry</a></para>
/// </summary>
public sealed class SphereGeometry : BufferGeometry
{
    public SphereGeometry() : base("SphereGeometry")
    {
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="radius">Radius of the sphere. Default is 1.</param>
    /// <param name="widthSegments">Number of horizontal segments. Minimum value is 3, and the default is 32.</param>
    /// <param name="heightSegments">Number of vertical segments. Minimum value is 2, and the default is 16.</param>
    /// <param name="phiStart">Specifies horizontal starting angle. Default is 0.</param>
    /// <param name="phiLength">Specifies horizontal sweep angle size. Default is Math.PI * 2.</param>
    /// <param name="thetaStart">Specifies vertical starting angle. Default is 0.</param>
    /// <param name="thetaLength">Specifies vertical sweep angle size. Default is Math.PI * 2.</param>
    public SphereGeometry(
        double radius = 1,
        int widthSegments = 32,
        int heightSegments = 16,
        double phiStart = 0,
        double phiLength = (double)(2 * Math.PI),
        double thetaStart = 0,
        double thetaLength = (double)(2 * Math.PI)) : this()
    {
        Radius = radius;
        WidthSegments = widthSegments;
        HeightSegments = heightSegments;
        PhiStart = phiStart;
        PhiLength = phiLength;
        ThetaStart = thetaStart;
        ThetaLength = thetaLength;
    }

    /// <summary>
    /// Radius of the sphere. Default is 1.
    /// </summary>
    public double Radius { get; set; } = 1;

    /// <summary>
    /// Number of horizontal segments. Minimum value is 3, and the default is 32.
    /// </summary>
    public int WidthSegments { get; set; } = 32;

    /// <summary>
    /// Number of vertical segments. Minimum value is 2, and the default is 16.
    /// </summary>
    public int HeightSegments { get; set; } = 16;

    /// <summary>
    /// Specifies horizontal starting angle. Default is 0.
    /// </summary>
    public double PhiStart { get; set; } = 0;

    /// <summary>
    /// Specifies horizontal sweep angle size. Default is Math.PI * 2.
    /// </summary>
    public double PhiLength { get; set; } = (double)(2 * Math.PI);

    /// <summary>
    /// Specifies vertical starting angle. Default is 0.
    /// </summary>
    public double ThetaStart { get; set; } = 0;

    /// <summary>
    /// Specifies vertical sweep angle size. Default is Math.PI * 2.
    /// </summary>
    public double ThetaLength { get; set; } = (double)(2 * Math.PI);
}