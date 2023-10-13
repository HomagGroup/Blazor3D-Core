using HomagGroup.Blazor3D.Enums;
using HomagGroup.Blazor3D.Materials;
using HomagGroup.Blazor3D.Maths;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomagGroup.Blazor3D.Settings
{
    public class SpriteImportSettings
    {
        /// <summary>
        /// URL of the sprite image.
        /// </summary>
        public string FileURL { get; set; } = null!;

        /// <summary>
        /// UUID of the object to be loaded. Nullable. If not specified, the new Guid is genrated.
        /// </summary>
        public Guid? Uuid { get; set; } = null;

        /// <summary>
        /// <para>Material that will be applied to loaded sprites.</para>
        /// <para>If not specified, the default <see cref="SpriteMaterial"/> is applied to the imported objects.</para>
        /// </summary>
        public SpriteMaterial Material { get; set; } = null!;

        /// <summary>
        /// Optional name of the object. Default is an empty string. It has not to be unique. 
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A Vector3 representing the object's local position. Default is (0,0,0).
        /// </summary>
        public Vector3 Position { get; set; } = new Vector3(0, 0, 0);

        /// <summary>
        /// Ojbect's local rotation
        /// </summary>
        public Euler Rotation { get; set; } = new Euler();

        /// <summary>
        /// The object's local scale. Default is a Vector3(1, 1, 1)
        /// </summary>
        public Vector3 Scale { get; set; } = new Vector3(1, 1, 1);
    }

}
