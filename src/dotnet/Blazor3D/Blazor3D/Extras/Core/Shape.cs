using HomagGroup.Blazor3D.Geometires;

namespace HomagGroup.Blazor3D.Extras.Core;

/// <summary>
/// Defines an arbitrary 2d shape plane using paths with optional holes).
/// It can be used with <see cref="ExtrudeGeometry"/>, <see cref="ShapeGeometry"/>, to get points, or to get triangulated faces.
/// </summary>
public class Shape
{
    /// <summary>
    /// <a href="https://en.wikipedia.org/wiki/Universally_unique_identifier" target="_blank">Universal unique identifier</a>
    /// </summary>
    public Guid Uuid { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Array of <see cref="Vector2"/> representing the shape verticies.
    /// </summary>
    public List<Vector2> Points { get; set; } = new List<Vector2>();

    /// <summary>
    /// Moves the current point to the specified <see cref="Vector2"/> point. Can be used for the first element of the Points collection.
    /// </summary>
    /// <param name="point"><see cref="Vector2"/> point.</param>
    /// <exception cref="OverflowException">MoveTo() can be used only to define first shape point</exception>
    public void MoveTo(Vector2 point)
    {
        if (Points.Count > 0)
        {
            throw new OverflowException("MoveTo() can be used only to define first shape point");
        }
        Points.Add(point);
    }

    /// <summary>
    /// Moves the current point to the specified point.
    /// </summary>
    /// <param name="x">X coordinate of the specified point.</param>
    /// <param name="y">Y coordinate of the specified point.</param>
    public void MoveTo(double x, double y)
    {
        MoveTo(new Vector2(x, y));
    }

    /// <summary>
    /// Adds the <see cref="Vector2"/> vertice to the shape path.
    /// </summary>
    /// <param name="point"><see cref="Vector2"/> point.</param>
    /// <exception cref="OverflowException">LineTo() cannot be used to define first shape point</exception>
    public void LineTo(Vector2 point)
    {
        if (Points.Count == 0)
        {
            throw new OverflowException("LineTo() cannot be used to define first shape point");
        }
        Points.Add(point);
    }

    /// <summary>
    /// Adds the vertice to the shape path.
    /// </summary>
    /// <param name="x">X coordinate of the specified vertice.</param>
    /// <param name="y">Y coordinate of the specified vertice.</param>
    public void LineTo(double x, double y)
    {
        LineTo(new Vector2(x, y));
    }
}