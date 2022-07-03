using Blazor3D.Core;
using Blazor3D.Objects;

namespace Blazor3D.Scenes
{
    public class Scene : Object3D
    {
        private List<Mesh> _children = new List<Mesh>();
        public Scene() : base("Scene")
        {

        }
        public string BackGroundColor { get; set; } = "DarkSlateBlue";

        public override Mesh[] Children => _children.ToArray();

        public void Add(Mesh child)
        {
            _children.Add(child);
        }
    }
}
