using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// A class for generating cylinder geometries.
    /// </summary>
    public sealed class CylinderGeometry : BufferGeometry
    {
        public CylinderGeometry() : base("CylinderGeometry")
        {
        }

        /// <summary>
        ///  Radius of the cylinder at the top. Default is 1.
        /// </summary>
        public float RadiusTop { get; set; } = 1;
        /// <summary>
        /// Radius of the cylinder at the bottom. Default is 1.
        /// </summary>
        public float RadiusBottom { get; set; } = 1;
        /// <summary>
        /// Height of the cylinder. Default is 1.
        /// </summary>
        public float Height { get; set; } = 1;
        /// <summary>
        /// Number of segmented faces around the circumference of the cylinder. Default is 8.
        /// </summary>
        public int RadialSegments { get; set; } = 8;
        /// <summary>
        /// Number of rows of faces along the height of the cylinder. Default is 1.
        /// </summary>
        public int HeightSegments { get; set; } = 1;
        /// <summary>
        /// A Boolean indicating whether the ends of the cylinder are open or capped. Default is false, meaning capped.
        /// </summary>
        public bool OpenEnded { get; set; } = false;
        /// <summary>
        /// Start angle for first segment. Default is 0 (three o'clock position).
        /// </summary>
        public float ThetaStart { get; set; } = 0;
        /// <summary>
        /// The central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.
        /// </summary>
        public float ThetaLength { get; set; } = (float)(2 * System.Math.PI);
    }
}
