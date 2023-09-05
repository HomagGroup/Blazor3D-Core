using System.ComponentModel.DataAnnotations;

namespace HomagGroup.Blazor3D.Settings
{
    /// <summary>
    /// Class for HomagGroup.Blazor3D Viewer WebGLRenderer settings.
    /// </summary>
    public class WebGLRendererSettings
    {
        /// <summary>
        /// Whether to perform antialiasing. Default is true.
        /// </summary>
        public bool Antialias { get; set; } = true;

        /// <summary>
        /// controls the default clear alpha value. When set to true, the value is 0. Otherwise it's 1. Default is false.
        /// </summary>
        [Range(0, 1, ErrorMessage = "Invalid Alpha value, Please submit a valid value. 0 for true or 1 for false.")]
        public int Alpha { get; set; } = 1;
    }
}