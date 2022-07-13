namespace Blazor3D.Lights
{
    /// <summary>
    /// <para>A light that gets emitted from a single point in all directions. A common use case for this is to replicate the light emitted from a bare lightbulb.</para>
    /// <para>This light can cast shadows</para>
    /// <para>This class inherits from <see cref="Light"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/lights/PointLight">PointLight</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Light"/></inheritdoc>
    public sealed class PointLight : Light
    {
        public PointLight() : base("PointLight")
        {

        }
        /// <summary>
        /// <para>When distance value is NOT 0, light will attenuate linearly from maximum intensity at the light's position down to zero at this distance from the light.</para>
        /// <para>When distance is zero, light does not attenuate.</para>
        /// <para>Default is 0.</para>
        /// </summary>
        public double Distance { get; set; } = 0;

        /// <summary>
        /// <para>The amount the light dims along the distance of the light</para>
        /// <para>Default is 1.</para>
        /// </summary>
        public float Decay { get; set; } = 1;
    }
}
