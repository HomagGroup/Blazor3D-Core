using Blazor3D.Core;


namespace Blazor3D.Helpers
{
    /// <summary>
    /// <para>The PolarGridHelper is an object to define polar grids. Grids are two-dimensional arrays of lines.</para>
    /// <para>This object inherits from <see cref="Object3D"/></para> //TODO: derive from Line
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/PolarGridHelper">PolarGridHelper</a></para>
    /// </summary>
    public class PolarGridHelper : Object3D //TODO: derive from Line
    {
        public PolarGridHelper() : base("PolarGridHelper")
        {
        }

        public PolarGridHelper(
            double radius = 10,
            int radials = 16,
            int circles = 8,
            int divisions = 64,
            string color1 = "0x444444",
            string color2 = "0x888888") : this()
        {
            Radius = radius;
            Radials = radials;
            Circles = circles;
            Divisions = divisions;
            Color1 = color1;
            Color2 = color2;
        }

        /// <summary>
        /// The radius of the polar grid. This can be any positive number. Default is 10.
        /// </summary>
        public double Radius { get; set; } = 10;

        /// <summary>
        /// The number of radial lines. This can be any positive integer. Default is 16.
        /// </summary>
        public int Radials { get; set; } = 16;

        /// <summary>
        /// The number of circles. This can be any positive integer. Default is 8.
        /// </summary>
        public int Circles { get; set; } = 8;
        /// <summary>
        /// The number of line segments used for each circle. This can be any positive integer that is 3 or greater. Default is 64.
        /// </summary>
        public int Divisions { get; set; } = 64;

        /// <summary>
        /// The first color used for grid elements. This can be a Color, a hexadecimal value and an CSS-Color name. Default is "0x444444".
        /// </summary>
        public string Color1 { get; set; } = "0x444444";

        /// <summary>
        /// The second color used for grid elements. This can be a Color, a hexadecimal value and an CSS-Color name. Default is 0x888888
        /// </summary>
        public string Color2 { get; set; } = "0x888888";
    }
}
