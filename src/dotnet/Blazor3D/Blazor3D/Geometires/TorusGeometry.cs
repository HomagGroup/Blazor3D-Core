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
        /// Radius of the torus, from the center of the torus to the center of the tube. Default is 1.
        /// </summary>
        public float Radius { get; set; } = 1;

        /// <summary>
        /// Radius of the tube. Default is 0.4.
        /// </summary>
        public float Tube { get; set; } = 0.4f;

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
        public float Arc { get; set; } = (float)(2 * Math.PI);
    }
}
