using Blazor3D.Math;

namespace Blazor3D.Core
{
    public abstract class Object3D
    {
        protected Object3D(string type)
        {
            Type = type;
        }

        public Vector3 Position { get; set; } = new Vector3();

        public string Type { get; } = "Object3D";

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Guid Uuid { get; set; } = Guid.NewGuid();

        public List<Object3D> Children { get;} = new List<Object3D>();

        public void Add(Object3D child)
        {
            Children.Add(child);
        }
    }
}
