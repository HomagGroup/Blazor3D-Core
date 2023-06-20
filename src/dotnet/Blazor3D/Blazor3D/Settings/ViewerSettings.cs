using Blazor3D.Viewers;

namespace Blazor3D.Settings
{
    /// <summary>
    /// Class for Blazor3D Viewer settings.
    /// </summary>
    public sealed class ViewerSettings
    {
        /// <summary>
        /// <para>Identifier of the html container where <see cref="Viewer"/>instance will be created.</para>
        /// <para>Must be unique on the html page! Default is "blazorview3d"</para>
        /// </summary>
        public string ContainerId { get; set; } = "blazorview3d";

        /// <summary>
        /// If true, user can select objects by mouse. Default is false.
        /// </summary>
        public bool CanSelect { get; set; } = false;

        /// <summary>
        /// If true, the helpers can be selected by mouse. Default is false.
        /// </summary>
        public bool CanSelectHelpers { get; set; } = false;

        /// <summary>
        /// Color the selected element is highlighted. Default is "lime".
        /// </summary>
        public string SelectedColor { get; set; } = "lime";

        /// <summary>
        /// Show or hide ViewHelper
        /// </summary>
        public bool ShowViewHelper { get; set; } = true;

        /// <summary>
        /// Blazor3D Viewer WebGLRenderer settings
        /// </summary>
        public WebGLRendererSettings WebGLRendererSettings { get; set; } = new WebGLRendererSettings();
    }
}
