using Blazor3D.Extras.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor3D.Geometires
{
    public class TextGeometryOptions
    {
        /// <summary>
        /// The path or URL to the font file. This can also be a Data URI.
        /// </summary>
        /// <remarks>This is the equivalent of what is passed into FontLoader.load() as the url parameter.</remarks>
        public string Font { get; set; }

        /// <summary>
        /// Size of the text
        /// </summary>
        public float Size { get; set; } = 100;

        /// <summary>
        /// Thickness to extrude text
        /// </summary>
        public float Height { get; set; } = 50;

        /// <summary>
        /// Number of points on the curves
        /// </summary>
        public int CurveSegments { get; set; } = 12;

        /// <summary>
        /// Turn on bevel, default false.
        /// </summary>
        public bool BevelEnabled { get; set; }

        /// <summary>
        /// How deep into text bevel goes
        /// </summary>
        public float BevelThickness { get; set; } = 10;

        /// <summary>
        /// How far from text outline (including <see cref="BevelOffset"/>) is the bevel
        /// </summary>
        public float BevelSize { get; set; } = 8;

        /// <summary>
        /// How far from text outline does bevel start
        /// </summary>
        public float BevelOffset { get; set; } = 0;
    }
}
