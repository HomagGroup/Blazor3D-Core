using Blazor3D.Core;

namespace Blazor3D.Geometires.Text
{
    /// <summary>
    /// Represents geometry to build extruded text
    /// </summary>
    public class TextExtrudeGeometry : TextShapeGeometry
    {
        public TextExtrudeGeometry() : base("TextExtrudeGeometry")
        {
        }

        /// <summary>
        /// Thickness to extrude text. Default is 50.
        /// </summary>
        public double Height { get; set; } = 50;

        /// <summary>
        /// Number of points on the curves. Default is 12.
        /// </summary>
        public int CurveSegments { get; set; } = 12;

        /// <summary>
        /// Turn on bevel. Default is False.
        /// </summary>
        public bool BevelEnabled { get; set; } = false;

        /// <summary>
        /// How deep into text bevel goes. Default is 10.
        /// </summary>
        public double BevelThickness { get; set; } = 10;

        /// <summary>
        /// How far from text outline is bevel. Default is 8.
        /// </summary>
        public double BevelSize { get; set; } = 8;

        /// <summary>
        /// How far from text outline bevel starts. Default is 0.
        /// </summary>
        public double BevelOffset { get; set; } = 0;

        /// <summary>
        /// Number of bevel segments
        /// </summary>
        public int BevelSegments { get; set; } = 3;
    }
}
