using Blazor3D.Enums;

namespace Blazor3D.Core
{
    /// <summary>
    /// Buffer geometry abstract class
    /// </summary>
    public abstract class BufferGeometry
    {
        protected BufferGeometry(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Name des
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Guid
        /// </summary>
        public Guid Uuid { get; set; } = Guid.NewGuid();

        public string Type { get; } = "Geometry";
    }
}
