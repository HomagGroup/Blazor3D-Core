using Blazor3D.Core;
using Blazor3D.Objects;

namespace Blazor3D.Scenes
{
    public class Scene : Object3D
    {
        //private List<Mesh> _children = new List<Mesh>();
        public Scene() : base("Scene")
        {

        }
        public string BackGroundColor { get; set; } = "DarkSlateBlue";

        public List<Mesh> Children { get; set; } = new List<Mesh>();

        public void Add(Mesh child)
        {
            Children.Add(child);
        }
    }
}
