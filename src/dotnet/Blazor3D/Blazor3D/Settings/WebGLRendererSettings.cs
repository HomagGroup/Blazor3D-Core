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
        public bool Alpha { get; set; } = false;
        
        /// <summary>
        /// whether the renderer will assume that colors have premultiplied alpha. Default is true.
        /// </summary>
        public bool PremultipliedAlpha { get; set; } = true;
    }
}
