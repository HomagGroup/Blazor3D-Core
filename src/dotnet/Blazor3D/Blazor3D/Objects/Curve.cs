using HomagGroup.Blazor3D.Core;

namespace HomagGroup.Blazor3D.Objects
{
    /// <summary>
    /// An abstract base class for creating a Curve object that contains methods for interpolation. 
    /// For an array of Curves see CurvePath.
    /// </summary>
    public abstract class Curve : Object3D
    {
        /// <summary>
        /// This value determines the amount of divisions when calculating the cumulative segment lengths of a curve via .getLengths. 
        /// To ensure precision when using methods like .getSpacedPoints, it is recommended to increase .arcLengthDivisions if the curve is very large. Default is 200.
        /// </summary>
        public int ArcLengthDivisions { get; set; } = 200;

        /// <summary>
        /// number of pieces to divide the curve into. Default is 5.
        /// </summary>
        public int Divisions { get; set; } = 5;

        protected Curve(string type) : base(type)
        {
        }
    }
}
