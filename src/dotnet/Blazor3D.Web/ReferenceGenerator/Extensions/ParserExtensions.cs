namespace ReferenceGenerator.Extensions
{
    public static class ParserExtensions
    {
        public static string ParseSummary(this string str)
        {
            var res = str;
            if (str.Contains("<see cref"))
            {
                res = str
                    .Replace("\\r\\n", "</br>")
                    .Replace("<see cref=\"T:Blazor3D.Cameras.Camera\" />", "<a href=\"Blazor3D.Cameras.Camera.html\">Camera</a>")
                    .Replace("<see cref=\"T:Blazor3D.Cameras.PerspectiveCamera\" />", "<a href=\"Blazor3D.Cameras.PerspectiveCamera.html\">PerspectiveCamera</a>")
                    .Replace("<see cref=\"T:Blazor3D.Controls.OrbitControls\" />", "<a href=\"Blazor3D.Controls.OrbitControls.html\">OrbitControls</a>")
                    .Replace("<see cref=\"T:Blazor3D.Core.BufferGeometry\" />", "<a href=\"Blazor3D.Core.BufferGeometry.html\">BufferGeometry</a>")
                    .Replace("<see cref=\"T:Blazor3D.Core.Object3D\" />", "<a href=\"Blazor3D.Core.Object3D.html\">Object3D</a>")
                    .Replace("<see cref=\"T:Blazor3D.Geometires.BoxGeometry\" />", "<a href=\"Blazor3D.Geometires.BoxGeometry.html\">BoxGeometry</a>")
                    .Replace("<see cref=\"T:Blazor3D.Geometires.CircleGeometry\" />", "<a href=\"Blazor3D.Geometires.CircleGeometry.html\">CircleGeometry</a>")
                    .Replace("<see cref=\"T:Blazor3D.Lights.AmbientLight\" />", "<a href=\"Blazor3D.Lights.AmbientLight.html\">AmbientLight</a>")
                    .Replace("<see cref=\"T:Blazor3D.Lights.Light\" />", "<a href=\"Blazor3D.Lights.Light.html\">Light</a>")
                    .Replace("<see cref=\"T:Blazor3D.Lights.PointLight\" />", "<a href=\"Blazor3D.Lights.PointLight.html\">PointLight</a>")
                    .Replace("<see cref=\"T:Blazor3D.Materials.Material\" />", "<a href=\"Blazor3D.Materials.Material.html\">Material</a>")
                    .Replace("<see cref=\"T:Blazor3D.Materials.MeshStandardMaterial\" />", "<a href=\"Blazor3D.Materials.MeshStandardMaterial.html\">MeshStandardMaterial</a>")
                    .Replace("<see cref=\"T:Blazor3D.Maths.Euler\" />", "<a href=\"Blazor3D.Maths.Euler.html\">Euler</a>")
                    .Replace("<see cref=\"T:Blazor3D.Maths.Vector3\" />", "<a href=\"Blazor3D.Maths.Vector3.html\">Vector3</a>")
                    .Replace("<see cref=\"T:Blazor3D.Objects.Group\" />", "<a href=\"Blazor3D.Objects.Group.html\">Group</a>")
                    .Replace("<see cref=\"T:Blazor3D.Objects.Mesh\" />", "<a href=\"Blazor3D.Objects.Mesh.html\">Mesh</a>")
                    .Replace("<see cref=\"T:Blazor3D.Scenes.Scene\" />", "<a href=\"Blazor3D.Scenes.Scene.html\">Scene</a>")
                    .Replace("<see cref=\"T:Blazor3D.Settings.ViewerSettings\" />", "<a href=\"Blazor3D.Settings.ViewerSettings.html\">ViewerSettings</a>")
                    .Replace("<see cref=\"T:Blazor3D.Viewers.Viewer\" />", "<a href=\"Blazor3D.Viewers.Viewer.html\">Viewer</a>");
            }
            return res;
        }
    }
}
