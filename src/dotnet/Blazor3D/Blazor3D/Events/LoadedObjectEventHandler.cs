namespace HomagGroup.Blazor3D.Events
{
    /// <summary>
    /// <para>Delegate that handles <see cref="Viewers.Viewer"/> ObjectLoaded event.</para>
    /// </summary>
    /// <param name="e"><see cref="Object3DArgs"/> arguments for ObjectLoaded event handler.</param>
    public delegate Task LoadedObjectEventHandler(Object3DArgs e);
}
