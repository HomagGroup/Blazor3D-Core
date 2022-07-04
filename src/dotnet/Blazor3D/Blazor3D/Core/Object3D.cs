using Blazor3D.Math;

namespace Blazor3D.Core
{
    public abstract class Object3D
    {
        //private List<Object3D> _children = new List<Object3D>();
        protected Object3D(string type)
        {
            Type = type;
        }

        public int Id { get; set; }

        public Vector3 Position { get; set; } = new Vector3();

        public string Type { get; } = "Object3D";

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string UUID { get; set; } = string.Empty;

        //serialization error. use custom serializer
        //public Object3D? Parent { get; set; } = null;

        //public virtual Object3D[] Children => _children.ToArray();

        //public virtual void Add(Object3D child)
        //{
        //    //serialization error. use custom serialize
        //    //child.Parent = this;
        //    _children.Add(child);
        //}
    }
}
