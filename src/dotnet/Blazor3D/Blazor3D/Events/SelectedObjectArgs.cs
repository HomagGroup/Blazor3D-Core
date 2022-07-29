namespace Blazor3D.Events
{
    internal class SelectedObjectStaticArgs
    {
        public string ContainerId { get; set; } = null!;

        public Guid UUID { get; set; }
    }

    /// <summary>
    /// Arguments for <see cref="Viewers.Viewer"/> ObjectSelected event.
    /// </summary>
    public class SelectedObjectArgs
    {
        /// <summary>
        /// Selected object unique identifier.
        /// </summary>
        public Guid UUID { get; set; }
    }
}
