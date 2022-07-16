using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    public sealed class RingGeometry : BufferGeometry
    {
        public RingGeometry() : base("RingGeometry")
        {
        }

        /// <summary>
        ///  Inner radius of the ring. Default is 0.5.
        /// </summary>
        public float InnerRadius { get; set; } = 0.5f;
        /// <summary>
        /// Outer radius of the ring. Default is 1.
        /// </summary>
        public float OuterRadius { get; set; } = 1;
        /// <summary>
        /// Number of segments. A higher number means the ring will be more round. Minimum is 3. Default is 8.
        /// </summary>
        public int ThetaSegments { get; set; } = 8;
        /// <summary>
        /// Number of rows of faces from inner to outer radii. Minimum is 1. Default is 1.
        /// </summary>
        public int PhiSegments { get; set; } = 1;
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
