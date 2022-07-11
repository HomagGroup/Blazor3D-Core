namespace Blazor3D.Lights
{
    /// <summary>
    /// <p>A light that gets emitted from a single point in all directions. A common use case for this is to replicate the light emitted from a bare lightbulb.</p>
    /// <p>This light can cast shadows</p>
    /// <p>This class inherits from <see cref="Light"/></p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/lights/PointLight">PointLight</a></p>
    /// </summary>
    /// <inheritdoc><see cref="Light"/></inheritdoc>
    public sealed class PointLight : Light
    {
        public PointLight() : base("PointLight")
        {

        }
        /// <summary>
        /// <p>When distance value is NOT 0, light will attenuate linearly from maximum intensity at the light's position down to zero at this distance from the light.</p>
        /// <p>When distance is zero, light does not attenuate.</p>
        /// <p>Default is 0.</p>
        /// </summary>
        public double Distance { get; set; } = 0;

        /// <summary>
        /// <p>The amount the light dims along the distance of the light</p>
        /// <p>Default is 1.</p>
        /// </summary>
        public float Decay { get; set; } = 1;
    }
}
