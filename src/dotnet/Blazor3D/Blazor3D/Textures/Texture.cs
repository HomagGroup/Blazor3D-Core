using Blazor3D.Enums;
using Blazor3D.Maths;

namespace Blazor3D.Textures
{
    public class Texture
    {
        public Texture() { }

        protected Texture(string type) 
        {
            Type = type;
        }

        public string Type { get; } = "Texture";


        /// <summary>
        /// Optional name of the texture (doesn't need to be unique). Default is an empty string. 
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/Universally_unique_identifier" target="_blank">Universal unique identifier</a> of this object instance. It's automatically assigned Guid, so it shouldn't be edited.
        /// </summary>
        public Guid Uuid { get; set; } = Guid.NewGuid();

        /// <summary>
        /// URL of the texture image file.
        /// </summary>
        public string TextureUrl { get; set; } = string.Empty;

        /// <summary>
        /// <para>This defines how the texture is wrapped horizontally and corresponds to U in UV mapping.</para>
        /// <para>The default is <see cref="WrappingType.ClampToEdgeWrapping"/>, where the edge is clamped to the outer edge texels.</para>
        /// <para>See the <see cref="WrappingType"/> for details.</para>
        /// </summary>
        public WrappingType WrapS { get; set; } = WrappingType.ClampToEdgeWrapping;

        /// <summary>
        /// <para>This defines how the texture is wrapped vertically and corresponds to V in UV mapping.</para>
        /// <para>The same choices are available as for WrapS. See the <see cref="WrappingType"/> for details.</para>
        /// <para>NOTE: tiling of images in textures only functions if image dimensions are powers of two (2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, ...) in terms of pixels. Individual dimensions need not be equal, but each must be a power of two. This is a limitation of WebGL, not three.js.</para>
        /// </summary>
        public WrappingType WrapT { get; set; } = WrappingType.ClampToEdgeWrapping;

        /// <summary>
        /// <para>How many times the texture is repeated across the surface, in each direction U and V. </para>
        /// <para>If repeat is set greater than 1 in either direction, the corresponding Wrap parameter should also be set to <see cref="WrappingType.RepeatWrapping"/> or <see cref="WrappingType.MirroredRepeatWrapping"/> to achieve the desired tiling effect.</para>
        /// <para>Setting different repeat values for textures is restricted in the same way like Offset.</para>
        /// </summary>
        public Vector2 Repeat { get; set; } = new Vector2(1, 1);

        /// <summary>
        /// <para>How much a single repetition of the texture is offset from the beginning, in each direction U and V. Typical range is 0.0 to 1.0.</para>
        /// <para>For more details see <a target="_blank" href="https://threejs.org/docs/index.html?q=texture#api/en/textures/Texture.offset">here</a> </para>
        /// </summary>
        public Vector2 Offset { get; set; } = new Vector2(0, 0);

        /// <summary>
        /// The point around which rotation occurs. A value of (0.5, 0.5) corresponds to the center of the texture. Default is (0, 0), the lower left.
        /// </summary>
        public Vector2 Center { get; set; } = new Vector2(0, 0);

        /// <summary>
        /// How much the texture is rotated around the center point, in radians. Positive values are counter-clockwise. Default is 0.
        /// </summary>
        public double Rotation { get; set; } = 0;
    }
}
