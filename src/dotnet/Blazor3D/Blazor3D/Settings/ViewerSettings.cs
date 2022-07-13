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
        /// <para>Must be unique on the html page!</para>
        /// </summary>
        public string ContainerId { get; set; } = "blazorview3d";
    }
}
