namespace HomagGroup.Blazor3D.Geometires.Text;

/// <summary>
/// Represents geometry to build stroke text 
/// </summary>
public class TextStrokeGeometry : TextShapeGeometry
{
    /// <summary>
    /// Constructor
    /// </summary>
    public TextStrokeGeometry() : base("TextStrokeGeometry")
    {
        }

    /// <summary>
    /// Stroke width
    /// </summary>
    public double StrokeWidth { get; set; } = 1;
}