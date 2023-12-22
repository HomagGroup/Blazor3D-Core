using HomagGroup.Blazor3D.Geometires;
using HomagGroup.Blazor3D.Textures;

namespace HomagGroup.Blazor3D.Objects;

/// <summary>
/// <para>Class representing triangulated polygon mesh based objects. Also serves as a base for other classes.</para>
/// <para>This object inherits from <see cref="Object3D"/></para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/objects/Mesh">Mesh</a></para>
/// </summary>
/// <inheritdoc><see cref="Object3D"/></inheritdoc>
public class Sprite : Object3D
{
    public Sprite() : base("Sprite")
    {
            
    }

    protected Sprite(string type) : base(type)
    {

    }

    /// <summary>
    /// <para>Collection of <see cref="HomagGroup.Blazor3D.Materials.Material"/> (or derived classes) materials, defining the object's appearance.</para>
    /// </summary>
    public SpriteMaterial Material { get; set; } = new SpriteMaterial();

    /// <summary>
    /// <para>The sprite's anchor point, and the point around which the sprite rotates. A value of (0.5,0.5)</para>
    /// <para>coresponds to the midpoint of the sprite. A value of (0,0) corresponds to the lower left corner of the sprite.</para>
    /// <para>The default is (0.5,0.5)</para>
    /// </summary>
    public Vector2 Center { get; set; } = new Vector2(0.5,0.5);
}