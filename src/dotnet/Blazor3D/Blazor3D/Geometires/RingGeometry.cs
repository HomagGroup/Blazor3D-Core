using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>A class for generating a two-dimensional ring geometry.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/RingGeometry">RingGeometry</a></para>
    /// </summary>
    public sealed class RingGeometry : BufferGeometry
    {
        public RingGeometry() : base("RingGeometry")
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="innerRadius">Inner radius of the ring. Default is 0.5.</param>
        /// <param name="outerRadius">Outer radius of the ring. Default is 1.</param>
        /// <param name="thetaSegments">Number of segments. A higher number means the ring will be more round. Minimum is 3. Default is 8.</param>
        /// <param name="phiSegments">Number of rows of faces from inner to outer radii. Minimum is 1. Default is 1.</param>
        /// <param name="thetaStart">Start angle for first segment. Default is 0 (three o'clock position).</param>
        /// <param name="thetaLength">The central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.</param>
        public RingGeometry(
            double innerRadius = 0.5f,
            double outerRadius = 1,
            int thetaSegments = 8,
            int phiSegments = 1,
            double thetaStart = 0,
            double thetaLength = (double)(2 * Math.PI)) : this()
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            ThetaSegments = thetaSegments;
            PhiSegments = phiSegments;
            ThetaStart = thetaStart;
            ThetaLength = thetaLength;
        }


        /// <summary>
        ///  Inner radius of the ring. Default is 0.5.
        /// </summary>
        public double InnerRadius { get; set; } = 0.5f;

        /// <summary>
        /// Outer radius of the ring. Default is 1.
        /// </summary>
        public double OuterRadius { get; set; } = 1;

        /// <summary>
        /// Number of segments. A higher number means the ring will be more round. Minimum is 3. Default is 8.
        /// </summary>
        public int ThetaSegments { get; set; } = 8;

        /// <summary>
        /// Number of rows of faces from inner to outer radii. Minimum is 1. Default is 1.
        /// </summary>
        public int PhiSegments { get; set; } = 1;

        /// <summary>
        /// Start angle for first segment. Default is 0 (three o'clock position).
        /// </summary>
        public double ThetaStart { get; set; } = 0;

        /// <summary>
        /// The central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.
        /// </summary>
        public double ThetaLength { get; set; } = (double)(2 * Math.PI);
    }
}
