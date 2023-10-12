using HomagGroup.Blazor3D.Geometires.Curves;
using HomagGroup.Blazor3D.Materials;

namespace HomagGroup.Blazor3D.Objects
{
    /// <summary>
    /// Create a smooth 2d spline curve from a series of points. Internally this uses Interpolations.CatmullRom to create the curve.
    /// </summary>
    public class SplineCurve : Curve
    {
        public SplineCurve() : base("SplineCurve")
        {
        }

        /// <summary>
        /// <para>Collection of <see cref="HomagGroup.Blazor3D.Materials.Material"/> (or derived classes) materials, defining the object's appearance.</para>
        /// </summary>
        public LineBasicMaterial Material { get; set; } = new LineBasicMaterial();

        /// <summary>
        /// <para>An instance of <see cref="SplineCurveGeometry"/> (or derived classes), defining the object's structure.</para>
        /// </summary>
        public SplineCurveGeometry Geometry { get; set; } = new SplineCurveGeometry();
    }
}