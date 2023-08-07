using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Maths;

namespace HomagGroup.Blazor3D.Helpers
{
    /// <summary>
    /// Helper object to visualize a <see cref="Plane"/>.
    /// <para>This object inherits from <see cref="Object3D"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/PlaneHelper">PlaneHelper</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public sealed class PlaneHelper : Object3D
    {
        public PlaneHelper() : base("PlaneHelper")
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to visualize.</param>
        /// <param name="size">Side length of plane helper. Default is 1.</param>
        /// <param name="color">The color of the helper. Default is "0xffff00".</param>
        public PlaneHelper(Plane plane = null!, double size = 1, string color = "0xffff00") : this()
        {
            Plane = plane ?? new Plane();
            Size = size;
            Color = color;
        }

        /// <summary>
        /// The <see cref="Plane"/> to visualize.
        /// </summary>
        public Plane Plane { get; set; } = new Plane();

        /// <summary>
        /// Side length of plane helper. Default is 1.
        /// </summary>
        public double Size { get; set; } = 1;

        /// <summary>
        /// The color of the helper. Default is "0xffff00".
        /// </summary>
        public string Color { get; set; } = "0xffff00";
    }
}
