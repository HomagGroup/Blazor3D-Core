﻿using Blazor3D.Core;

namespace Blazor3D.Geometires.Text
{
    public class TextShapeGeometry : BufferGeometry
    {
        public TextShapeGeometry() : base("TextShapeGeometry")
        {
        }

        protected TextShapeGeometry(string type) : base(type)
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
    }
}