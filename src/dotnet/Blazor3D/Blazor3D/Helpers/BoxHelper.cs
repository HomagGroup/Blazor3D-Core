using Blazor3D.Core;

namespace Blazor3D.Helpers
{
    /// <summary>
    /// <para>Helper object to graphically show the world-axis-aligned bounding box around an object.</para>
    /// <para>This object inherits from <see cref="Object3D"/></para> //TODO: derive from LineSegments
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/BoxHelper">BoxHelper</a></para>
    /// </summary>
    public class BoxHelper : Object3D //TODO: derive from LineSegments
    {
        public BoxHelper() : base("BoxHelper")
        {
        }

        public BoxHelper(Object3D object3d = null!, string color = "0xffff00") : this()
        {
            Object3D = object3d;
            Color = color;
        }

        /// <summary>
        /// The <see cref="Object3D"/> to show the world-axis-aligned boundingbox.
        /// </summary>
        public Object3D Object3D { get; set; }

        public string Color { get; set; } = "0xffff00";

    }
}
