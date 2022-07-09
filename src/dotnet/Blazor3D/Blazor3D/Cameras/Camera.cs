using Blazor3D.Core;

namespace Blazor3D.Cameras
{
    /// <summary>
    /// <p>Abstract base class for cameras.</p>
    /// </summary>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/cameras/Camera">Camera</a></p>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public abstract class Camera : Object3D
    {
        protected Camera(string type = "Camera") : base(type)
        {
        }
    }
}
