using Blazor3D.Maths;

namespace Blazor3D.Settings
{
    /// <summary>
    /// <para>Settings used for animated rotations.</para>
    /// </summary>
    public sealed class AnimateRotationSettings
    {
        public AnimateRotationSettings()
        {

        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="animateRotation">The option indicates whether the rotation animation should be applied. Default is false.</param>
        /// <param name="thetaX">The angle in degreees to rotate around the X axis on each animation frame. Default is 0.1.</param>
        /// <param name="thetaY">The angle in degreees to rotate around the Y axis on each animation frame. Default is 0.1.</param>
        /// <param name="thetaZ">The angle in degreees to rotate around the Z axis on each animation frame. Default is 0.1.</param>
        /// <param name="radius">Radius of rotation. Default is 5.</param>
        public AnimateRotationSettings(bool animateRotation = false,  double thetaX = 0.1, double thetaY = 0.1, double thetaZ = 0.1, double radius = 5)
        {
            AnimateRotation = animateRotation;
            ThetaX = thetaX;
            ThetaY = thetaY;
            ThetaZ = thetaZ;
            Radius = radius;
        }

        /// <summary>
        /// The option indicates whether the rotation animation should be applied. Default is false.
        /// </summary>
        public bool AnimateRotation { get; set; } = false;

        /// <summary>
        /// The angle in degreees to rotate around the X axis on each animation frame. Default is 0.1.
        /// </summary>
        public double ThetaX { get; set; } = 0.1;
        /// <summary>
        /// The angle in degreees to rotate around the Y axis on each animation frame. Default is 0.1.
        /// </summary>
        public double ThetaY { get; set; } = 0.1;
        /// <summary>
        /// The angle in degreees to rotate around the Z axis on each animation frame. Default is 0.1.
        /// </summary>
        public double ThetaZ { get; set; } = 0.1;
        /// <summary>
        /// Radius of rotation. Default is 5.
        /// </summary>
        public double Radius { get; set; } = 5;
    }
}
