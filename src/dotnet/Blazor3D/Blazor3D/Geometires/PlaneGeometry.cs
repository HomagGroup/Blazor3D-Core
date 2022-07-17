using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// A class for generating plane geometries.
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/PlaneGeometry">PlaneGeometry</a></para>
    /// </summary>
    public sealed class PlaneGeometry : BufferGeometry
    {
        public PlaneGeometry() : base("PlaneGeometry")
        {
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="width">The length of the edges parallel to the X axis. Default is 1.</param>
        /// <param name="height">The length of the edges parallel to the Y axis. Default is 1.</param>
        /// <param name="widthSegments">Number of segmented rectangular faces along the width of the sides. Default is 1.</param>
        /// <param name="heightSegments">Number of segmented rectangular faces along the height of the sides. Default is 1.</param>
        public PlaneGeometry(float width = 1, float height = 1, int widthSegments = 1, int heightSegments = 1) : this()
        {
            Width = width;
            Height = height;
            WidthSegments = widthSegments;
            HeightSegments = heightSegments;
        }

        /// <summary>
        /// The length of the edges parallel to the X axis. Default is 1.
        /// </summary>
        public float Width { get; set; } = 1;

        /// <summary>
        /// The length of the edges parallel to the Y axis. Default is 1.
        /// </summary>
        public float Height { get; set; } = 1;

        /// <summary>
        /// Number of segmented rectangular faces along the width of the sides. Default is 1.
        /// </summary>
        public int WidthSegments { get; set; } = 1;

        /// <summary>
        /// Number of segmented rectangular faces along the height of the sides. Default is 1.
        /// </summary>
        public int HeightSegments { get; set; } = 1;
    }
}
