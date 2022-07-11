namespace Blazor3D.Lights
{
    /// <summary>
    /// <p>This light globally illuminates all objects in the scene equally.
    /// This light cannot be used to cast shadows as it does not have a direction.</p>
    /// <p>This class inherits from <see cref="Light"/></p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/lights/AmbientLight">AmbientLight</a></p>
    /// </summary>
    /// <inheritdoc><see cref="Light"/></inheritdoc>
    public sealed class AmbientLight : Light
    {
        public AmbientLight() : base("AmbientLight")
        {
            Intensity = 0.6f;
        }
    }
}
