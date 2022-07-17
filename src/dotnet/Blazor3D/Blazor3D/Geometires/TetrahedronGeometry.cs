using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>A class for generating a tetrahedron geometries.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/TetrahedronGeometry">TetrahedronGeometry</a></para>
    /// </summary>
    public sealed class TetrahedronGeometry : BufferGeometry
    {
        public TetrahedronGeometry() : base("TetrahedronGeometry")
        {
        }
        /// <summary>
        /// Radius of the tetrahedron. Default is 1.
        /// </summary>
        public float Radius { get; set; } = 1;
        /// <summary>
        ///  Default is 0. Setting this to a value greater than 0 adds more vertices making it no longer an tetrahedron.
        /// </summary>
        public int Detail { get; set; } = 0;
    }
}
