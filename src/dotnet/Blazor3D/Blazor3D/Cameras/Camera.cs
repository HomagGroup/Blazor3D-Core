using Blazor3D.Core;

namespace Blazor3D.Cameras
{
    public abstract class Camera : Object3D
    {
        protected Camera(string type = "Camera") : base(type)
        {
        }
    }
}
