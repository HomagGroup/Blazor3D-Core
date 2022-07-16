using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// A class for generating a dodecahedron geometries.
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
        public float Detail { get; set; } = 0;
    }
}
