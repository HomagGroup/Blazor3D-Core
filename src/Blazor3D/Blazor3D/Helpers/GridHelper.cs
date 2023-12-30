namespace HomagGroup.Blazor3D.Helpers;

/// <summary>
/// <para>The GridHelper is an object to define grids. Grids are two-dimensional arrays of lines.</para>
/// <para>This object inherits from <see cref="Object3D"/></para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/GridHelper">GridHelper</a></para>
/// </summary>
/// <inheritdoc><see cref="Object3D"/></inheritdoc>
public sealed class GridHelper : Object3D
{
    public GridHelper() : base("GridHelper")
    {
    }

    public GridHelper(double size = 10, int devisions = 10, string colorCenterLine = "0x444444",
        string colorGrid = "0x888888") : this()
    {
        Size = size;
        Divisions = devisions;
        ColorCenterLine = colorCenterLine;
        ColorGrid = colorGrid;
    }

    /// <summary>
    /// The size of the grid. Default is 10.
    /// </summary>
    public double Size { get; set; } = 10;

    /// <summary>
    /// The number of divisions across the grid. Default is 10.
    /// </summary>
    public int Divisions { get; set; } = 10;

    /// <summary>
    /// The color of the centerline. This can be a Color, a hexadecimal value and an CSS-Color name. Default is "0x444444:.
    /// </summary>
    public string ColorCenterLine { get; set; } = "0x444444";

    /// <summary>
    /// The color of the lines of the grid. This can be a Color, a hexadecimal value and an CSS-Color name. Default is "0x888888".
    /// </summary>
    public string ColorGrid { get; set; } = "0x888888";
}