using Blazor3D.Core;

namespace Blazor3D.Lights
{
    public abstract class Light : Object3D
    {
        protected Light(string type = "Light") : base(type)
        {
        }
        public string Color { get; set; } = "white";
        public float Intensity { get; set; } = 1;
    }
}
