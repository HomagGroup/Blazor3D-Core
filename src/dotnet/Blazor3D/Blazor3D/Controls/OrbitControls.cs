using Blazor3D.Maths;

namespace Blazor3D.Controls
{
    /// <summary>
    /// Orbit controls.
    /// </summary>
    public sealed class OrbitControls
    {
        /// <summary>
        /// If true, then enabled. Otherwise, disabled. Default is true.
        /// </summary>
        public bool Enabled { get; set; } = true;
        /// <summary>
        /// Minimal distance. Default is 0.
        /// </summary>
        public float MinDistance { get; set; } = 0;
        /// <summary>
        /// Maximal distance to zoom. Default is 10000;
        /// </summary>
        public float MaxDistance { get; set; } = 10000;

        /// <summary>
        /// The point where the camera is looking at. Default is (0,0,0).
        /// </summary>
        public Vector3 TargetPosition { get; set; } = new Vector3();
    }
}
