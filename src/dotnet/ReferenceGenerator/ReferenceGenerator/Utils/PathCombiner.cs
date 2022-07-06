namespace ReferenceGenerator.Utils
{
    public static class PathCombiner
    {
        public static string Combine(string path1, string path2)
        {
            if (Path.IsPathRooted(path2))
            {
                path2 = path2.TrimStart(Path.DirectorySeparatorChar);
                path2 = path2.TrimStart(Path.AltDirectorySeparatorChar);
            }

            return Path.Combine(path1, path2);
        }

        public static string Combine(string path1, string path2, string path3)
        {
            if (Path.IsPathRooted(path2))
            {
                path2 = path2.TrimStart(Path.DirectorySeparatorChar);
                path2 = path2.TrimStart(Path.AltDirectorySeparatorChar);
            }

            if (Path.IsPathRooted(path3))
            {
                path2 = path3.TrimStart(Path.DirectorySeparatorChar);
                path2 = path3.TrimStart(Path.AltDirectorySeparatorChar);
            }

            return Path.Combine(path1, path2);
        }
    }
}
