namespace Blazor3D.Cameras
{
    /// <summary>
    /// <para>Camera that uses <a target="_blank" href="https://en.wikipedia.org/wiki/Orthographic_projection">orthographic projection</a>.</para>
    /// <para>In this projection mode, an object's size in the rendered image stays constant regardless of its distance from the camera.</para>
    /// <para>This can be useful for rendering 2D scenes and UI elements, amongst other things.</para>
    /// </summary>
    public sealed class OrthographicCamera : Camera
    {
        public OrthographicCamera() : base("OrthographicCamera")
        {

        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="left">Camera frustum left plane. Default is -1.</param>
        /// <param name="right">Camera frustum right plane. Default is 1.</param>
        /// <param name="top">Camera frustum top plane. Default is 1.</param>
        /// <param name="bottom">Camera frustum bottom plane. Default is -1.</param>
        /// <param name="near">Camera frustum near plane distance. Default is 0.1.</param>
        /// <param name="far">Camera frustum far plane distance. Default is 1000.</param>
        /// <param name="zoom">Zoom factor of the camera. Default is 1.</param>
        public OrthographicCamera(double left = -1, double right = 1, double top = 1, double bottom = -1, double near = 0.1, double far = 2000, double zoom = 1)
        {
            Left = left;
            Right = right;
            Top = top;
            Bottom = bottom;
            Near = near;
            Far = far;
            Zoom = zoom;
        }

        /// <summary>
        /// Camera frustum left plane. Default is -1.
        /// </summary>
        public double Left { get; set; } = -1;

        /// <summary>
        /// Camera frustum right plane. Default is 1.
        /// </summary>
        public double Right { get; set; } = 1;

        /// <summary>
        /// Camera frustum top plane. Default is 1.
        /// </summary>
        public double Top { get; set; } = 1;

        /// <summary>
        ///  Camera frustum bottom plane. Default is -1.
        /// </summary>
        public double Bottom { get; set; } = -1;

        /// <summary>
        /// Camera frustum near plane distance. Default is 0.1.
        /// </summary>
        public double Near { get; set; } = 0.1;

        /// <summary>
        /// Camera frustum far plane distance. Default is 1000.
        /// </summary>
        public double Far { get; set; } = 2000;

        /// <summary>
        /// Zoom factor of the camera. Default is 1.
        /// </summary>
        public double Zoom { get; set; } = 1;
    }
}
