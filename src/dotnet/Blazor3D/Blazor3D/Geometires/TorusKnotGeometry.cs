using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>Class for torus knot, the particular shape of which is defined by a pair of coprime integers, p and q. If p and q are not coprime, the result will be a torus link.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/TorusKnotGeometry">TorusKnotGeometry</a></para>
    /// </summary>
    public sealed class TorusKnotGeometry : BufferGeometry
    {
        public TorusKnotGeometry() : base("TorusKnotGeometry")
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
        /// Number of tubular segments. Default is 64.
        /// </summary>
        public int TubularSegments { get; set; } = 64;

        /// <summary>
        /// This value determines, how many times the geometry winds around its axis of rotational symmetry. Default is 2.
        /// </summary>
        public int P { get; set; } = 2;

        /// <summary>
        /// This value determines, how many times the geometry winds around a circle in the interior of the torus. Default is 3.
        /// </summary>
        public int Q { get; set; } = 3;
    }
}
