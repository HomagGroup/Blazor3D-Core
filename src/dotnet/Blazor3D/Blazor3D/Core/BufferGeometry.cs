using Blazor3D.Enums;

namespace Blazor3D.Core
{
    public abstract class BufferGeometry
    {
        protected BufferGeometry(string type)
        {
            Type = type;
        }

        public string Name { get; set; } = null!;

        public Guid Uuid { get; set; } = Guid.NewGuid();

        public string Type { get; } = "Geometry";
    }
}
