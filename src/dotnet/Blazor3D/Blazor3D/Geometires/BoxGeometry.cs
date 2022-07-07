using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <p>Class for rectangular cuboid with a given 'width', 'height', and 'depth'.</p>
    /// <p>This class inherits from <see cref="BufferGeometry"/></p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/BoxGeometry">BoxGeometry</a></p>
    /// </summary>
    /// <inheritdoc><see cref="BufferGeometry"/></inheritdoc>
    public sealed class BoxGeometry : BufferGeometry
    {
        public BoxGeometry() : base("BoxGeometry")
        {

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
