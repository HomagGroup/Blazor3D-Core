using Blazor3D.Components.Common;

namespace Blazor3D.Components.Options
{
    public class CameraOptions
    {
        public double Fov { get; set; } = 75;
        public double Near { get; set; } = 0.1;
        public double Far { get; set; } = 1000;
        public Position Position { get; } = new Position();
    }
}
