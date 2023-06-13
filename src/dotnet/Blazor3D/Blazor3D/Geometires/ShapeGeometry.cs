using Blazor3D.Core;
using Blazor3D.Extras.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// Creates an one-sided polygonal geometry from one or more path shapes.
    /// </summary>
    public class ShapeGeometry : BufferGeometry
    {
        public ShapeGeometry() : base("ShapeGeometry")
        {
        }

        /// <summary>
        /// onstructor with parameters
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> polygonal shape.</param>
        public ShapeGeometry(Shape shape):this()
        {
            Shape = shape;
        }

        /// <summary>
        /// <see cref="Shape"/> polygonal shape.
        /// </summary>
        public Shape Shape { get; set; } = new Shape();
    }
}
