using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>Class for rectangular cuboid with a given 'width', 'height', and 'depth'.</para>
    /// <para>This class inherits from <see cref="BufferGeometry"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/BoxGeometry">BoxGeometry</a></para>
    /// </summary>
    /// <inheritdoc><see cref="BufferGeometry"/></inheritdoc>
    public sealed class BoxGeometry : BufferGeometry
    {
        public BoxGeometry() : base("BoxGeometry")
        {

        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="width">The length of the edges parallel to the X axis. Default is 1.</param>
        /// <param name="height">The length of the edges parallel to the Y axis. Default is 1.</param>
        /// <param name="depth">The length of the edges parallel to the Z axis. Default is 1.</param>
        /// <param name="widthSegments">Number of segmented rectangular faces along the width of the sides. Default is 1.</param>
        /// <param name="heightSegments">Number of segmented rectangular faces along the height of the sides. Default is 1.</param>
        /// <param name="depthSegments">Number of segmented rectangular faces along the depth of the sides. Default is 1.</param>
        public BoxGeometry(
            float width = 1,
            float height = 1,
            float depth = 1,
            int widthSegments = 1,
            int heightSegments = 1,
            int depthSegments = 1):this()
        {
            Width = width;
            Height = height;
            Depth = depth;
            WidthSegments = widthSegments;
            HeightSegments = heightSegments;
            DepthSegments = depthSegments;
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
        /// The length of the edges parallel to the Z axis. Default is 1.
        /// </summary>
        public float Depth { get; set; } = 1;

        /// <summary>
        /// Number of segmented rectangular faces along the width of the sides. Default is 1.
        /// </summary>
        public int WidthSegments { get; set; } = 1;

        /// <summary>
        /// Number of segmented rectangular faces along the height of the sides. Default is 1.
        /// </summary>
        public int HeightSegments { get; set; } = 1;

        /// <summary>
        /// Number of segmented rectangular faces along the depth of the sides. Default is 1.
        /// </summary>
        public int DepthSegments { get; set; } = 1;
    }
}
