using Blazor3D.Maths;

namespace Blazor3D.Core
{
    /// <summary>
    /// Object3D
    /// </summary>
    public abstract class Object3D
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="type">type</param>
        protected Object3D(string type)
        {
            Type = type;
        }

        /// <summary>
        /// position
        /// </summary>
        public Vector3 Position { get; set; } = new Vector3();

        public Euler Rotation { get; set; } = new Euler();

        public Vector3 Scale { get; set; } = new Vector3(1, 1, 1);

        public string Type { get; } = "Object3D";

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Guid Uuid { get; set; } = Guid.NewGuid();

        public List<Object3D> Children { get; } = new List<Object3D>();

        public void Add(Object3D child)
        {
            Children.Add(child);
        }
    }
}
