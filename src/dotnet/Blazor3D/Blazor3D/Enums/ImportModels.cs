namespace HomagGroup.Blazor3D.Enums;

/// <summary>
/// 3D model formats, which can be used for importing to or exporting from <see cref="Scene"/>.
/// </summary>
public enum Import3DFormats
{
    /// <summary>
    ///<a target="_blank" href="https://en.wikipedia.org/wiki/Wavefront_.obj_file">Wavefront Object</a> format.
    /// </summary>
    Obj,
    /// <summary>
    /// <a target="_blank" href="https://en.wikipedia.org/wiki/COLLADA">Collada</a> format.
    /// </summary>
    Collada,
    /// <summary>
    /// <a target="_blank" href="https://en.wikipedia.org/wiki/FBX">Autodesk FBX</a> format.
    /// </summary>
    Fbx,
    /// <summary>
    /// <a target="_blank" href="https://en.wikipedia.org/wiki/GlTF">glTF</a> format.
    /// </summary>
    Gltf,
    /// <summary>
    /// <a target="_blank" href="https://en.wikipedia.org/wiki/STL_(file_format)">Stl</a> format.
    /// </summary>
    Stl,
    /// <summary>
    /// <a target="_blank" href="https://en.wikipedia.org/wiki/Universal_Scene_Description">Usdz</a> format.
    /// </summary>
    Usdz
}