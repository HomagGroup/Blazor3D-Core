using Blazor3D.Core;

namespace Blazor3D.Objects
{
    /// <summary>
    /// <p>This is almost identical to an <see cref="Object3D"/>. Its purpose is to make working with groups of objects syntactically clearer.</p>
    /// <p>This object inherits from <see cref="Object3D"/></p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/objects/Group">Group</a></p>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public class Group : Object3D
    {
        public Group() : base("Group")
        {
        }
    }
}
