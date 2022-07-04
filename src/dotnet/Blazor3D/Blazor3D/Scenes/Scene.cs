using Blazor3D.Core;
using Blazor3D.Objects;

namespace Blazor3D.Scenes
{
    public class Scene : Object3D
    {

        public Scene() : base("Scene")
        {

        }
        public string BackGroundColor { get; set; } = "DarkSlateBlue";
    }
}
