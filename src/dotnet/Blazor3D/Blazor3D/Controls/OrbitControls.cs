namespace HomagGroup.Blazor3D.Controls;

/// <summary>
/// Orbit controls.
/// </summary>
public sealed class OrbitControls
{
    /// <summary>
    /// If true, then enabled. Otherwise, disabled. Default is true.
    /// </summary>
    public bool Enabled { get; set; } = true;
    /// <summary>
    /// Minimal distance. Default is 0.
    /// </summary>
    public double MinDistance { get; set; } = 0;
    /// <summary>
    /// Maximal distance to zoom. Default is 10000;
    /// </summary>
    public double MaxDistance { get; set; } = 10000;

    /// <summary>
    /// The point where the camera is looking at. Default is (0,0,0).
    /// </summary>
    public Vector3 TargetPosition { get; set; } = new Vector3();

    /// <summary>
    /// If true, then panning enabled. Otherwise, panning disabled. Default is true
    /// </summary>
    public bool EnablePan { get; set; } = true;

    /// <summary>
    /// If true, than damping enabled. Otherwise, damping disabled. Default is true
    /// </summary>
    public bool EnableDamping { get; set; } = false;

    /// <summary>
    /// Damping factor. Default is 0.05
    /// </summary>
    public double DampingFactor = 0.05;
}