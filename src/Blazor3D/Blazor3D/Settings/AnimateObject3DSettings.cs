namespace HomagGroup.Blazor3D.Settings;

/// <summary>
/// <para>Settings used for animations on Object3D/>.</para>
/// </summary>
public class AnimateObject3DSettings
{
    /// <summary>
    /// The option indicates whether the animation on the object should be applied. Default is false.
    /// </summary>
    public bool AnimateObject { get; set; } = false;

    /// <summary>
    /// a list of <see cref="Vector3"/> points representing the path for object movement.
    /// </summary>
    public List<Vector3> Points { get; set; } = new List<Vector3>();

    /// <summary>
    /// The animation speed
    /// </summary>
    public int Speed { get; set; } = 1;

    /// <summary>
    /// An index pointer for traversing the <see cref="Points"/> list
    /// </summary>
    public int IndexPointer { get; set; } = 0;

    /// <summary>
    /// The option to indicate whether the animation should restart when it finishes.
    /// </summary>
    public bool LoopAnimation { get; set; } = false;
}