using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para></para>A class for generating cone geometries.
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/ConeGeometry">ConeGeometry</a></para>
    /// </summary>
    public sealed class ConeGeometry : BufferGeometry
    {
        public ConeGeometry() : base("ConeGeometry")
        {
        }

        /// <summary>
        /// Radius of the cone base. Defaults to 1.
        /// </summary>
        public float Radius { get; set; } = 1;
        /// <summary>
        /// Height of the cone. Default is 1.
        /// </summary>
        public float Height { get; set; } = 1;
        /// <summary>
        /// Number of segmented faces around the circumference of the cone. Default is 8.
        /// </summary>
        public int RadialSegments { get; set; } = 8;
        /// <summary>
        /// Number of rows of faces along the height of the cone. Default is 1.
        /// </summary>
        public int HeightSegments { get; set; } = 1;
        /// <summary>
        /// A Boolean indicating whether the base of the cone is open or capped. Default is false, meaning capped.
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
