using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    public class CircleGeometry : BufferGeometry
    {
        public CircleGeometry() : base("CircleGeometry")
        {
        }

        public float Radius { get; set; } = 1;

        public int Segments { get; set; } = 8;

        public float ThetaStart { get; set; } = 0;

        public float ThetaLength { get; set; } = (float)(2*System.Math.PI);

    }
}
