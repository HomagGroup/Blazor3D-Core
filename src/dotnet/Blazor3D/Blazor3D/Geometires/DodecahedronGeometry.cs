using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>A class for generating a dodecahedron geometries.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/DodecahedronGeometry">DodecahedronGeometry</a></para>
    /// </summary>
    public class DodecahedronGeometry : BufferGeometry
    {
        public DodecahedronGeometry() : base("DodecahedronGeometry")
        {
        }
        /// <summary>
        /// Radius of the dodecahedron. Default is 1.
        /// </summary>
        public float Radius { get; set; } = 1;
        /// <summary>
        /// Default is 0. Setting this to a value greater than 0 adds vertices making it no longer a dodecahedron.
        /// </summary>
        public int Detail { get; set; } = 0;
    }
}
