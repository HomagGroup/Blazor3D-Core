namespace Blazor3D.Lights
{
    public class AmbientLight : Light
    {
        public AmbientLight() : base("AmbientLight")
        {
            Intensity = 0.6f;
        }
    }
}
