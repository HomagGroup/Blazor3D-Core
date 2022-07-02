using Blazor3D.Components.Enums;

namespace Blazor3D.Components.Geometries
{
    public class BufferGeometry
    {
        

        protected BufferGeometry(GeometryType geometryType)
        {
            GeometryType = geometryType;
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string UUID { get; set; } = null!;

        public GeometryType GeometryType { get;} =  GeometryType.None;
    }
}
