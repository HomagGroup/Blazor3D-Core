using Blazor3D.Core;
using Blazor3D.Maths;

namespace Blazor3D.Helpers
{
    /// <summary>
    /// <para>An 3D arrow object for visualizing directions.</para>
    /// <para>This object inherits from <see cref="Object3D"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/ArrowHelper">ArrowHelper</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public sealed class ArrowHelper : Object3D
    {
        public ArrowHelper() : base("ArrowHelper")
        {
        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="dir">Direction from origin. Must be a unit vector. It's normilized before applying. Default is (0, 0, 1).</param>
        /// <param name="origin">Point at which the arrow starts. Default is (0, 0, 0).</param>
        /// <param name="length">Length of the arrow. Default is 1.</param>
        /// <param name="color">Color. Default is "0xffff00".</param>
        /// <param name="headLength">The length of the head of the arrow. Default is 0.2 * Length.</param>
        /// <param name="headWidth">The width of the head of the arrow. Default is 0.2 * HeadLength.</param>
        public ArrowHelper(
            Vector3 dir = null!,
            Vector3 origin = null!,
            double length = 1,
            string color = "0xffff00",
            double headLength = 0.2,
            double headWidth = 0.2 * 0.2) : this()
        {
            Dir = dir ?? new Vector3(0, 0, 1);
            Origin = origin ?? new Vector3(0, 0, 0);
            Length = length;
            Color = color;
            HeadLength = headLength;
            HeadWidth = headWidth;
        }

        /// <summary>
        ///  Direction from origin. Must be a unit vector. It's normilized before applying. Default is (0, 0, 1).
        /// </summary>
        public Vector3 Dir { get; set; } = new Vector3(0, 0, 1);

        /// <summary>
        /// Point at which the arrow starts. Default is (0, 0, 0).
        /// </summary>
        public Vector3 Origin { get; set; } = new Vector3(0, 0, 0);

        /// <summary>
        /// Length of the arrow. Default is 1.
        /// </summary>
        public double Length { get; set; } = 1;

        /// <summary>
        /// Color. Default is "0xffff00".
        /// </summary>
        public string Color { get; set; } = "0xffff00";

        /// <summary>
        /// The length of the head of the arrow. Default is 0.2 * Length.
        /// </summary>
        public double HeadLength { get; set; } = 0.2;

        /// <summary>
        /// The width of the head of the arrow. Default is 0.2 * HeadLength.
        /// </summary>
        public double HeadWidth { get; set; } = 0.2 * 0.2;
    }
}
