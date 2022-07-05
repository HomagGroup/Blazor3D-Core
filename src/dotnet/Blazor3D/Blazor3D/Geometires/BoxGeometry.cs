using Blazor3D.Core;
using Blazor3D.Enums;

namespace Blazor3D.Geometires
{
    public class BoxGeometry : BufferGeometry
    {
        public BoxGeometry() : base("BoxGeometry")
        {

        }
        public float Width { get; set; } = 1;
        public float Height { get; set; } = 1;
        public float Depth { get; set; } = 1;
        public int WidthSegments { get; set; } = 1;
        public int HeightSegments { get; set; } = 1;
        public int DepthSegments { get; set; } = 1;
    }
}
