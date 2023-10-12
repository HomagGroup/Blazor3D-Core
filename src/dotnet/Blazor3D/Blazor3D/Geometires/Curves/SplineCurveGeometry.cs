using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Maths;

namespace HomagGroup.Blazor3D.Geometires.Curves
{
    public class SplineCurveGeometry : BufferGeometry
    {
        public SplineCurveGeometry() : base("SplineCurveGeometry")
        {}

        public List<Vector2> Points { get; set; } = new List<Vector2>();
    }
}