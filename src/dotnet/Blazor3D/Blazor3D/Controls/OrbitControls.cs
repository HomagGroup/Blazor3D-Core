using Blazor3D.Math;

namespace Blazor3D.Controls
{
    public class OrbitControls
    {
        public bool Enabled { get; set; } = true;
        public float MinDistance { get; set; } = 0;
        public float MaxDistance { get; set; } = 10000;
        public Vector3 TargetPosition { get; set; } = new Vector3();
    }
}
