using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    public class TextGeometry : BufferGeometry
    {
        public TextGeometry() : base("TextGeometry")
        {
        }

        /// <summary>
        /// The text that needs to be shown
        /// </summary>
        public string Text { get; set; } = "Hello, Blazor3D!";

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
