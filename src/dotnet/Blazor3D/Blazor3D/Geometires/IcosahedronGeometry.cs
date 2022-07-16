using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>A class for generating an icosahedron geometry.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/IcosahedronGeometry">IcosahedronGeometry</a></para>
    /// </summary>
    public class IcosahedronGeometry : BufferGeometry
    {
        public IcosahedronGeometry() : base("IcosahedronGeometry")
        {
        }
        /// <summary>
        /// Radius of the icosahedron. Default is 1.
        /// </summary>
        public float Radius { get; set; } = 1;
        /// <summary>
        ///  Default is 0. Setting this to a value greater than 0 adds more vertices making it no longer an icosahedron. When detail is greater than 1, it's closer to a sphere.
        /// </summary>
        public int Detail { get; set; } = 0;
    }
}
