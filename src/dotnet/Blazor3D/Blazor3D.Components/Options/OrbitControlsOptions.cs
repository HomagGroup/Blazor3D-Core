using Blazor3D.Components.Common;

namespace Blazor3D.Components.Options
{
    public class OrbitControlsOptions
    {
        public double MinDistance { get; set; } = 0;
        public double MaxDistance { get; set; } = 10000;
        public Position TargetPosition { get; set; } = new Position();
    }
}
