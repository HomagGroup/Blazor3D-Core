using Blazor3D.Enums.Lines;
using System;

namespace Blazor3D.Materials
{
    /// <summary>
    /// A material for drawing wireframe-style geometries.
    /// </summary>
    public class LineBasicMaterial : Material
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public LineBasicMaterial() : base("LineBasicMaterial")
        {
        }

        /// <summary>
        /// Color of the material, by default set to white (0xffffff).
        /// </summary>
        public string Color { get; set; } = "white";

        /// <summary>
        /// Define appearance of line ends. Possible values are 'butt', 'round' and 'square'. Default is 'round'.
        /// </summary>
        public string LineCap { get; set; } = "round";// todo: deal with enum

        /// <summary>
        /// Define appearance of line joints. Possible values are 'round', 'bevel' and 'miter'. Default is 'round'.
        /// </summary>
        public string LineJoin { get; set; } = "round";// todo: deal with enum


        /// <summary>
        /// Controls line thickness. Default is 1.
        /// Due to limitations of the OpenGL Core Profile with the WebGL renderer on most platforms linewidth will always be 1 regardless of the set value.
        /// </summary>
        public double LineWidth { get; set; } = 1;
    }
}
