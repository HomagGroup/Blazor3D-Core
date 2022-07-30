namespace Blazor3D.Events
{
    internal class Object3DStaticArgs
    {
        public string ContainerId { get; set; } = null!;

        public Guid UUID { get; set; }
    }

    /// <summary>
    /// Arguments for <see cref="Viewers.Viewer"/> ObjectSelected and ObjectLoaded events.
    /// </summary>
    public class Object3DArgs
    {
        /// <summary>
        /// Selected or Loaded object unique identifier.
        /// </summary>
        public Guid UUID { get; set; }
    }
}
