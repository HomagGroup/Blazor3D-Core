using Blazor3D.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor3D.Geometires
{
    public class TextGeometry : BufferGeometry
    {
        public TextGeometry(string text, TextGeometryOptions options = null)
            : base("TextGeometry")
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            TextOptions = options ?? new TextGeometryOptions();
        }

        public string Text { get; set; }
        public TextGeometryOptions TextOptions { get; set; }
    }
}
