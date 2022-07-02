using Blazor3D.Components.Enums;
namespace Blazor3D.Components.Geometries
{
    public class BoxGeometry : BufferGeometry
    {
        public BoxGeometry():base(GeometryType.BoxGeometry)
        {

        }
        public BoxGeometry(float width = 1, float height = 1, float depth = 1, int widthSegments = 1, int heightSegments = 1, int depthSegments = 1) 
                : base(GeometryType.BoxGeometry)
        {
            Width = width;
            Height = height;
            Depth = depth;
            WidthSegments = widthSegments;
            HeightSegments = heightSegments;
            DepthSegments = depthSegments;
        }

        public float Width { get; set; } = 1;
        public float Height { get; set; } = 1;
        public float Depth { get; set; } = 1;
        public int WidthSegments { get; set; } = 1;
        public int HeightSegments { get; set; } = 1;
        public int DepthSegments { get; set; } = 1;
    }
}
