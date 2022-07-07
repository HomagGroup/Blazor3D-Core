namespace Blazor3D.Lights
{
    public sealed class PointLight : Light
    {
        public PointLight() : base("PointLight")
        {

        }

        public double Distance { get; set; } = 0;

        public float Decay { get; set; } = 1;
    }
}
