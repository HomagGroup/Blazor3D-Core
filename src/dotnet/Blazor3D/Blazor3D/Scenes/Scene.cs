using Blazor3D.Core;

namespace Blazor3D.Scenes
{
    /// <summary>
    /// <para>Scenes allow you to set up what and where is to be rendered by Blazor3D. 
    /// This is the place where you put your 3D objects and lights.</para>
    /// <para>This object inherits from <see cref="Object3D"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/scenes/Scene">Scene</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public sealed class Scene : Object3D
    {
        public Scene() : base("Scene")
        {

        }

        /// <summary>
        /// Scene background color. 
        /// You can use <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value">web color values</a> to set up required color.
        /// Default value is "DarkSlateBlue">
        /// </summary>
        public string BackGroundColor { get; set; } = "DarkSlateBlue";
    }
}
