using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Maths;
using HomagGroup.Blazor3D.Settings;

namespace HomagGroup.Blazor3D.Cameras
{
    /// <summary>
    /// <para>Abstract base class for cameras.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/cameras/Camera">Camera</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public abstract class Camera : Object3D
    {
        protected Camera(string type = "Camera") : base(type)
        {
        }

        /// <summary>
        /// Settings used for camera's animated rotations.
        /// </summary>
        public AnimateRotationSettings AnimateRotationSettings { get; set; } = new AnimateRotationSettings();

        /// <summary>
        /// The point camera looks at.
        /// </summary>
        public Vector3 LookAt { get; set; } = new Vector3();


        /// <summary>
        /// This is used by the LookAt method, for example, to determine the orientation of the result.
        /// Default is ( 0, 1, 0 ).
        /// </summary>
        public Vector3 Up { get; set; } = new Vector3(0, 1, 0);

    }
}
