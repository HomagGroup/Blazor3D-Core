using Blazor3D.Core;

namespace Blazor3D.Geometires
{
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
        /// Radius of the octahedron. Default is 1.
        /// </summary>
        public float Radius { get; set; } = 1;
        /// <summary>
        ///  Default is 0. Setting this to a value greater than 0 adds more vertices making it no longer an octahedron.
        /// </summary>
        public int Detail { get; set; } = 0;
    }
}
