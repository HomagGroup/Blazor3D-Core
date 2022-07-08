using ReferenceGenerator.Models;
using ReferenceGenerator.Utils;

namespace ReferenceGenerator
{
    public class HtmlGenerator
    {
        public async Task Generate(ReferenceModel reference, string refpath, string templatePath)
        {
            var referenceDirInfo = new DirectoryInfo(refpath);

            if (referenceDirInfo.Exists)
            {
                referenceDirInfo.Delete(true);
            }
            referenceDirInfo.Create();

            string templateStr = await File.ReadAllTextAsync(templatePath);
            var indexFileStr = templateStr;
            var referenceIndex = PathCombiner.Combine(referenceDirInfo.FullName, "Index.html");

            await File.WriteAllTextAsync(referenceIndex, indexFileStr);
        }
    }
}
