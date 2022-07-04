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

        public string UUID => Guid.NewGuid().ToString().ToLower();

        public GeometryType GeometryType { get; } = GeometryType.None;
    }
}
