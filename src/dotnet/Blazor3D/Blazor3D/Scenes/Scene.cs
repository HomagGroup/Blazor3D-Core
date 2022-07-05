using Blazor3D.Core;
using Blazor3D.Objects;

namespace Blazor3D.Scenes
{
    /// <summary>
    /// Scene d
    /// </summary>
    public class Scene : Object3D
    {
        /// <summary>
        /// ctor Scene
        /// </summary>
        /// <inheritdoc cref="Object3D"/>
        public Scene() : base("Scene")
        {

        }
        /// <summary>
        /// bgc
        /// </summary>
        public string BackGroundColor { get; set; } = "DarkSlateBlue";
    }
}
