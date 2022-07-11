using Blazor3D.Core;

namespace Blazor3D.Lights
{
    /// <summary>
    /// <p>Abstract base class for lights.</p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/lights/Light">Light</a></p>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public abstract class Light : Object3D
    {
        protected Light(string type = "Light") : base(type)
        {
        }

        /// <summary>
        /// <p>Light color. 
        /// You can use <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value">web color values</a> to set up required color.
        /// Default value is "white"</p>
        /// </summary>
        public string Color { get; set; } = "white";

        /// <summary>
        /// <p>Value of the light's strength/intensity. Default is 1.</p>
        /// </summary>
        public float Intensity { get; set; } = 1;
    }
}
