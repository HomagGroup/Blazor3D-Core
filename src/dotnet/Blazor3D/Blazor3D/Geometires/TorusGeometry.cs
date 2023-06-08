using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para> A class for generating torus geometries.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/TorusGeometry">TorusGeometry</a></para>
    /// </summary>
    public sealed class TorusGeometry : BufferGeometry
    {
        public TorusGeometry() : base("TorusGeometry")
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="radius">Radius of the torus, from the center of the torus to the center of the tube. Default is 1.</param>
        /// <param name="tube">Radius of the tube. Default is 0.4.</param>
        /// <param name="radialSegments">Number of radial segments. Default is 8.</param>
        /// <param name="tubularSegments">Number of tubular segments. Default is 6.</param>
        /// <param name="arc">Central angle. Default is Math.PI * 2.</param>
        public TorusGeometry(double radius = 1, double tube = 0.4f, int radialSegments = 8, int tubularSegments = 6, double arc = (double)(2 * Math.PI)) : this()
        {
            Radius = radius;
            Tube = tube;
            RadialSegments = radialSegments;
            TubularSegments = tubularSegments;
            Arc = arc;
        }

        /// <summary>
        /// Radius of the torus, from the center of the torus to the center of the tube. Default is 1.
        /// </summary>
        public double Radius { get; set; } = 1;

        /// <summary>
        /// Radius of the tube. Default is 0.4.
        /// </summary>
        public double Tube { get; set; } = 0.4f;

        /// <summary>
        /// Number of radial segments. Default is 8.
        /// </summary>
        public int RadialSegments { get; set; } = 8;

        /// <summary>
        /// Number of tubular segments. Default is 6.
        /// </summary>
        public int TubularSegments { get; set; } = 6;

        /// <summary>
        /// Central angle. Default is Math.PI * 2.
        /// </summary>
        public double Arc { get; set; } = (double)(2 * Math.PI);
    }
}
