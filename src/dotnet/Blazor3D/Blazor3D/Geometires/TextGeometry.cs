using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    public class TextGeometry : BufferGeometry
    {
        public TextGeometry() : base("TextGeometry")
        {
        }

        /// <summary>
        /// The path or URL to the file. This can also be a Data URI
        /// </summary>
        public string FontURL { get; set; } = string.Empty;

        /// <summary>
        /// Size of the text. Default is 100.
        /// </summary>
        public double Size { get; set; } = 100;

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
    }
}
