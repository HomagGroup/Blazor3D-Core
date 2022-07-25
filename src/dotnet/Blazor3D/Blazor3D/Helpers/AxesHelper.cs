using Blazor3D.Core;

namespace Blazor3D.Helpers
{
    /// <summary>
    /// <para>An axis object to visualize the 3 axes in a simple way.</para>
    /// <para>The X axis is red.The Y axis is green.The Z axis is blue.</para>
    /// <para>This object inherits from <see cref="Object3D"/></para> //TODO: derive from LineSegments
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/AxesHelper">AxesHelper</a></para>
    /// </summary>
    public class AxesHelper : Object3D //TODO: derive from LineSegments
    {
        public AxesHelper() : base("AxesHelper")
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="size">Size of the lines representing the axes. Default is 1.</param>
        public AxesHelper(double size = 1) : this()
        {
            Size = size;
        }


        /// <summary>
        /// Size of the lines representing the axes. Default is 1.
        /// </summary>
        public double Size { get; set; } = 1;
    }
}
