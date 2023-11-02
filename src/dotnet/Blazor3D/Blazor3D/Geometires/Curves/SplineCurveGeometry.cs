using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Maths;

namespace HomagGroup.Blazor3D.Geometires.Curves
{
    public class SplineCurveGeometry : BufferGeometry
    {
        public SplineCurveGeometry() : base("SplineCurveGeometry")
        {}

        public List<Vector2> Points { get; set; } = new List<Vector2>();
        
        /// <summary>
        /// This value determines the amount of divisions when calculating the cumulative segment lengths of a curve via .getLengths. 
        /// To ensure precision when using methods like .getSpacedPoints, it is recommended to increase .arcLengthDivisions if the curve is very large. Default is 200.
        /// </summary>
        public int ArcLengthDivisions { get; set; } = 200;

        /// <summary>
        /// number of pieces to divide the curve into. Default is 5.
        /// </summary>
        public int Divisions { get; set; } = 5;
    }
}