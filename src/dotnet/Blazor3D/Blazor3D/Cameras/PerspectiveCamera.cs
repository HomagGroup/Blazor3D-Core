namespace Blazor3D.Cameras
{
    public class PerspectiveCamera : Camera
    {
        public PerspectiveCamera() : base("PerspectiveCamera")
        {
        }

        public double Fov { get; set; } = 75;
        public double Near { get; set; } = 0.1;
        public double Far { get; set; } = 1000;
        public double Aspect { get; set; } = 4 / 3;
    }
}
