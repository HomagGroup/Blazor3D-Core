namespace Blazor3D.Cameras
{
    /// <summary>
    /// <para>Camera that uses perspective projection.
    /// This projection mode is designed to mimic the way the human eyes see.
    /// It is the most common projection mode used for rendering a 3D scene.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/cameras/PerspectiveCamera">PerspectiveCamera</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Camera"/></inheritdoc>
    public sealed class PerspectiveCamera : Camera
    {
        public PerspectiveCamera() : base("PerspectiveCamera")
        {
        }

        /// <summary>
        ///  Camera frustum vertical field of view. Default value is 75;
        /// </summary>
        public double Fov { get; set; } = 75;
        /// <summary>
        /// Camera frustum near plane distance.
        /// </summary>
        public double Near { get; set; } = 0.1;
        /// <summary>
        /// Camera frustum far plane distance.
        /// </summary>
        public double Far { get; set; } = 1000;
        /// <summary>
        ///  Camera frustum aspect ratio. It is calculated by Blazor3D component as current width divided by current height.
        /// </summary>
        public double Aspect { get; set; } = 4 / 3;
    }
}
