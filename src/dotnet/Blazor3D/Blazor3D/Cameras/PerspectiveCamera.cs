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
        /// Constructor with parameters.
        /// </summary>
        /// <param name="fov">Camera frustum vertical field of view. Default is 75.</param>
        /// <param name="near">Camera frustum near plane distance. Default is 0.1.</param>
        /// <param name="far">Camera frustum far plane distance. Default is 1000.</param>
        public PerspectiveCamera(double fov, double near, double far) : this()
        {
            Fov = fov;
            Near = near;
            Far = far;
        }

        /// <summary>
        ///  Camera frustum vertical field of view. Default is 75.
        /// </summary>
        public double Fov { get; set; } = 75;

        /// <summary>
        /// Camera frustum near plane distance. Default is 0.1.
        /// </summary>
        public double Near { get; set; } = 0.1;

        /// <summary>
        /// Camera frustum far plane distance. Default is 1000.
        /// </summary>
        public double Far { get; set; } = 1000;
    }
}
