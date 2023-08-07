using HomagGroup.Blazor3D.Core;

namespace HomagGroup.Blazor3D.Geometires
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
        /// Constructor with parameters
        /// </summary>
        /// <param name="radius">Radius of the torus, from the center of the torus to the center of the tube. Default is 1.</param>
        /// <param name="tube">Radius of the tube. Default is 0.4.</param>
        /// <param name="radialSegments">Number of radial segments. Default is 8.</param>
        /// <param name="tubularSegments">Number of tubular segments. Default is 64.</param>
        /// <param name="p">This value determines, how many times the geometry winds around its axis of rotational symmetry. Default is 2.</param>
        /// <param name="q">This value determines, how many times the geometry winds around a circle in the interior of the torus. Default is 3.</param>
        public TorusKnotGeometry(double radius = 1, double tube = 0.4f, int radialSegments = 8, int tubularSegments = 64, int p = 2, int q = 3) :this()
        {
            Radius = radius;
            Tube = tube;
            RadialSegments = radialSegments;
            TubularSegments = tubularSegments;
            P = p;
            Q = q;
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
