using Blazor3D.Enums;

namespace Blazor3D.Core
{
    public abstract class BufferGeometry
    {
        protected BufferGeometry(GeometryType geometryType)
        {
            GeometryType = geometryType;
        }

        public string Name { get; set; } = null!;

        public Guid Uuid { get; set; } = Guid.NewGuid();

        public GeometryType GeometryType { get; } = GeometryType.None;
    }
}
