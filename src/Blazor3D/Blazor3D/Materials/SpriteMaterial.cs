using HomagGroup.Blazor3D.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomagGroup.Blazor3D.Materials;

public class SpriteMaterial : Material
{
    public SpriteMaterial() : base("SpriteMaterial")
    {
    }

    /// <summary>
    /// The color map. May optionally include an alpha channel, typically combined with Transparent (todo) or AlphaTest(todo). Default is null. The texture map color is modulated by the diffuse Color.
    /// </summary>
    public Texture Map { get; set; } = new Texture();

    /// <summary>
    /// Whether the size of the sprite is attenuated by the camera depth. (Perspective camera only.)
    /// Default is true.
    /// </summary>
    public bool SizeAttenuation { get; set; } = true;

    /// <summary>
    /// The rotation of the sprite in radians. Default is 0.
    /// </summary>
    public double Rotation { get; set; } = 0;
}