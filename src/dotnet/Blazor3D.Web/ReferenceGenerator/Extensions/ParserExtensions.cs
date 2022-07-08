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
                    .Replace("<see cref=\"T:Blazor3D.Core.Object3D\" />", "<a href=\"Blazor3D.Core.Object3D.html\">Object3D</a>")
                    .Replace("<see cref=\"T:Blazor3D.Core.BufferGeometry\" />", "<a href=\"Blazor3D.Core.BufferGeometry.html\">BufferGeometry</a>")
                    .Replace("<see cref=\"T:Blazor3D.Maths.Euler\" />", "<a href=\"Blazor3D.Maths.Euler.html\">Euler</a>")
                    .Replace("<see cref=\"T:Blazor3D.Maths.Vector3\" />", "<a href=\"Blazor3D.Maths.Vector3.html\">Vector3</a>");
            }
            return res;
        }
    }
}
