using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>Class for a capsule with given radus and height. It is constructed using a lathe.</para>
    /// </summary>
    public sealed class CapsuleGeometry : BufferGeometry
    {
        public CapsuleGeometry() : base("CapsuleGeometry")
        {
        }

        /// <summary>
        /// Radius of the capsule. Defaults to 1.
        /// </summary>
        public float Radius { get; set; } = 1;
        /// <summary>
        /// Length of the middle section. Defaults to 1.
        /// </summary>
        public float Length { get; set; } = 1;
        /// <summary>
        /// Number of curve segments used to build the caps. Defaults to 4.
        /// </summary>
        public int CapSegments { get; set; } = 4;
        /// <summary>
        /// Number of segmented faces around the circumference of the capsule. Defaults to 8.
        /// </summary>
        public int RadialSegments { get; set; } = 8;



    }
}
